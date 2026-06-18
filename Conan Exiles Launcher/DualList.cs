using System.Collections;
using System.ComponentModel;
using System.Diagnostics;

namespace Conan_Exiles_Launcher
{
    public partial class DualList : Component
    {
        private IBindingList? _allItems;
        private IBindingList? _availableBindingList;
        private IBindingList? _selectedBindingList;

        [Category("Controls")]
        [Description("The list contains available items")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ListBox? AvailableItemsListBox
        {
            get;
            set
            {
                field?.SelectedIndexChanged -= AvailableItemsListBox_OnSelectedIndexChanged;
                field?.DataSourceChanged -= AvailableItemsListBox_OnDataSourceChanged;
                
                field = value;
                
                field?.SelectedIndexChanged += AvailableItemsListBox_OnSelectedIndexChanged;
                field?.DataSourceChanged += AvailableItemsListBox_OnDataSourceChanged;
            }
        }

        [Category("Controls")]
        [Description("The list contains selected items")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ListBox? SelectedItemsListBox
        {
            get;
            set
            {
                field?.SelectedIndexChanged -= SelectedItemsListBox_OnSelectedIndexChanged;
                field?.DataSourceChanged -= SelectedItemsListBox_OnDataSourceChanged;
                field?.DrawItem -= SelectedItemsListBox_DrawItem;
                
                field = value;

                field?.SelectedIndexChanged += SelectedItemsListBox_OnSelectedIndexChanged;
                field?.DataSourceChanged += SelectedItemsListBox_OnDataSourceChanged;
                field?.DrawItem += SelectedItemsListBox_DrawItem;

                field?.DrawMode = DrawMode.OwnerDrawFixed;
            }
        }

        [Category("Controls")]
        [Description("The moves an item from available to selected")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Button? SelectButton
        {
            get;
            set
            {
                field?.Click -= SelectButton_OnClick;
                
                field = value;
                
                field?.Click += SelectButton_OnClick;
            }
        }

        [Category("Controls")]
        [Description("The moves an item from selected to available")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Button? DeselectButton
        {
            get;
            set
            {
                field?.Click -= DeselectButton_OnClick;
                
                field = value;
                
                field?.Click += DeselectButton_OnClick;
            }
        }

        [Category("Controls")]
        [Description("The moves an item upward in the list of selected items")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Button? UpButton
        {
            get;
            set
            {
                field?.Click -= UpButton_OnClick;
                
                field = value;
                
                field?.Click += UpButton_OnClick;
            }
        }

        [Category("Controls")]
        [Description("The moves an item downward in the list of selected items")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Button? DownButton {
            get;
            set
            {
                field?.Click -= DownButton_OnClick;
                
                field = value;
                
                field?.Click += DownButton_OnClick;
            }
        }


        public DualList()
        {
            InitializeComponent();
        }

        public DualList(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void SetData<T>(ICollection<T> items)
        {
            if (AvailableItemsListBox == null)
            {
                return;
            }

            if (_allItems != null)
            {
                _allItems.ListChanged -= AllBindingList_ListChanged;
            }

            _allItems = new BindingList<object>();
            foreach (var item in items)
            {
                _allItems.Add(item);
            }

            _allItems.ListChanged += AllBindingList_ListChanged;

            SyncAvailableWithAll();
            RefreshSelectedListBoxColors();
            UpdateButtons();
        }

        private void AvailableItemsListBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void AvailableItemsListBox_OnDataSourceChanged(object sender, EventArgs e)
        {
            _availableBindingList?.ListChanged -= AvailableBindingList_ListChanged;
            _availableBindingList = null;

            var dataSource = AvailableItemsListBox?.DataSource;
            if (dataSource is IBindingList bindingList)
            {
                _availableBindingList = bindingList;
                _availableBindingList.ListChanged += AvailableBindingList_ListChanged;
            }

            SyncAvailableWithAll();
            RefreshSelectedListBoxColors();
            UpdateButtons();
        }

        private void AvailableBindingList_ListChanged(object? sender, ListChangedEventArgs e)
        {
            RefreshSelectedListBoxColors();
            UpdateButtons();
        }

        private void SelectedItemsListBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine($"DualList: SelectedItemsListBox_OnSelectedIndexChanged SelectedIndex={SelectedItemsListBox?.SelectedIndex} DataSource={(SelectedItemsListBox?.DataSource == null ? "null" : SelectedItemsListBox?.DataSource.GetType().FullName)} ItemsCount={SelectedItemsListBox?.Items.Count}");
            UpdateButtons();
        }

        private void SelectedItemsListBox_OnDataSourceChanged(object sender, EventArgs e)
        {
            if (_selectedBindingList != null)
            {
                _selectedBindingList.ListChanged -= SelectedBindingList_ListChanged;
                _selectedBindingList = null;
            }

            var dataSource = SelectedItemsListBox?.DataSource;
            if (dataSource is IBindingList bl)
            {
                _selectedBindingList = bl;
                _selectedBindingList.ListChanged += SelectedBindingList_ListChanged;
            }
            Debug.WriteLine($"DualList: SelectedItemsListBox_OnDataSourceChanged DataSource={(dataSource == null ? "null" : dataSource.GetType().FullName)} SelectedBindingList={( _selectedBindingList == null ? "null" : _selectedBindingList.GetType().FullName)} ItemsCount={SelectedItemsListBox?.Items.Count}");

            SyncAvailableWithAll();
            RefreshSelectedListBoxColors();
            UpdateButtons();
        }

        private void SelectedBindingList_ListChanged(object? sender, ListChangedEventArgs e)
        {
            Debug.WriteLine($"DualList: SelectedBindingList_ListChanged Type={e.ListChangedType} NewIndex={e.NewIndex} OldIndex={e.OldIndex}");
            SyncAvailableWithAll();
            RefreshSelectedListBoxColors();
            UpdateButtons();
        }

        private void SelectedItemsListBox_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (SelectedItemsListBox == null)
            {
                return;
            }

            if (e.Index < 0 || e.Index >= SelectedItemsListBox.Items.Count)
            {
                e.DrawBackground();
                return;
            }

            var item = SelectedItemsListBox.Items[e.Index];

            if (item == null)
            {
                e.DrawBackground();
                return;
            }

            var text = SelectedItemsListBox.GetItemText(item);
            var isAvailable = false;
            
            if (_allItems != null)
            {
                foreach (var o in _allItems)
                {
                    if (Equals(o, item))
                    {
                        isAvailable = true;
                        break;
                    }
                }
            }
            else if (AvailableItemsListBox != null)
            {
                foreach (var o in AvailableItemsListBox.Items)
                {
                    if (Equals(o, item))
                    {
                        isAvailable = true;
                        break;
                    }
                }
            }
            var color = isAvailable ? e.ForeColor : Color.Red;

            e.DrawBackground();
            using (var brush = new SolidBrush(color))
            {
                e.Graphics.DrawString(text, e.Font, brush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void SelectButton_OnClick(object sender, EventArgs e)
        {
            if (AvailableItemsListBox == null || SelectedItemsListBox == null)
            {
                return;
            }

            var item = AvailableItemsListBox.SelectedItem;
            if (item == null)
            {
                return;
            }

            if (AvailableItemsListBox.DataSource is IList availableItemsList)
            {
                availableItemsList.Remove(item);
            }
            else
            {
                AvailableItemsListBox.Items.Remove(item);
            }

            if (SelectedItemsListBox.DataSource is IList selectedItemsList)
            {
                selectedItemsList.Add(item);
            }
            else
            {
                SelectedItemsListBox.Items.Add(item);
            }

            RefreshSelectedListBoxColors();
            UpdateButtons();
        }

        private void DeselectButton_OnClick(object sender, EventArgs e)
        {
            if (AvailableItemsListBox == null || SelectedItemsListBox == null)
            {
                return;
            }

            var item = SelectedItemsListBox.SelectedItem;
            if (item == null)
            {
                return;
            }

            if (SelectedItemsListBox.DataSource is IList selectedItemsList)
            {
                selectedItemsList.Remove(item);
            }
            else
            {
                SelectedItemsListBox.Items.Remove(item);
            }

            if (AvailableItemsListBox.DataSource is IList availableItemsList)
            {
                availableItemsList.Add(item);
            }
            else
            {
                AvailableItemsListBox.Items.Add(item);
            }

            RefreshSelectedListBoxColors();
            UpdateButtons();
        }

        private void UpButton_OnClick(object sender, EventArgs e)
        {
            if (SelectedItemsListBox == null)
            {
                return;
            }

            var index = SelectedItemsListBox.SelectedIndex;
            if (index <= 0)
            {
                return;
            }

            if (SelectedItemsListBox.DataSource is IList selectedItemsList)
            {
                var item = selectedItemsList[index];
                selectedItemsList.RemoveAt(index);
                selectedItemsList.Insert(index - 1, item);
                SelectedItemsListBox.SelectedIndex = index - 1;
            }
            else
            {
                var items = SelectedItemsListBox.Items;
                var item = items[index];
                items.RemoveAt(index);
                items.Insert(index - 1, item);
                SelectedItemsListBox.SelectedIndex = index - 1;
            }

            RefreshSelectedListBoxColors();
            UpdateButtons();
        }

        private void DownButton_OnClick(object sender, EventArgs e)
        {
            if (SelectedItemsListBox == null)
            {
                return;
            }

            var index = SelectedItemsListBox.SelectedIndex;
            if (index < 0 || index >= SelectedItemsListBox.Items.Count - 1)
                return;

            if (SelectedItemsListBox.DataSource is IList selectedItemsList)
            {
                var item = selectedItemsList[index];
                selectedItemsList.RemoveAt(index);
                selectedItemsList.Insert(index + 1, item);
                SelectedItemsListBox.SelectedIndex = index + 1;
            }
            else
            {
                var items = SelectedItemsListBox.Items;
                var item = items[index];
                items.RemoveAt(index);
                items.Insert(index + 1, item);
                SelectedItemsListBox.SelectedIndex = index + 1;
            }

            RefreshSelectedListBoxColors();
            UpdateButtons();
        }

        private void AllBindingList_ListChanged(object? sender, ListChangedEventArgs e)
        {
            SyncAvailableWithAll();
            RefreshSelectedListBoxColors();
            UpdateButtons();
        }

        private void SyncAvailableWithAll()
        {
            if (AvailableItemsListBox == null)
            {
                return;
            }

            if (_allItems == null)
            {
                if (AvailableItemsListBox.DataSource is IBindingList bl)
                {
                    _allItems = bl;
                }
                else
                {
                    _allItems = new BindingList<object>();
                    foreach (var item in AvailableItemsListBox.Items)
                        _allItems.Add(item);
                }
                _allItems.ListChanged += AllBindingList_ListChanged;
            }

            var selectedSet = new HashSet<object>();
            if (SelectedItemsListBox != null)
            {
                if (SelectedItemsListBox.DataSource is IList selList)
                {
                    foreach (var s in selList)
                    {
                        if (s != null) selectedSet.Add(s);
                    }
                }
                else
                {
                    foreach (var s in SelectedItemsListBox.Items)
                    {
                        if (s != null) selectedSet.Add(s);
                    }
                }
            }

            bool InAllItems(object? item)
            {
                if (item == null) return false;
                foreach (var a in _allItems)
                {
                    if (Equals(a, item)) return true;
                }
                return false;
            }

            if (AvailableItemsListBox.DataSource is IList availableItemList)
            {
                for (int i = availableItemList.Count - 1; i >= 0; i--)
                {
                    var it = availableItemList[i];
                    if (!InAllItems(it) || selectedSet.Contains(it))
                    {
                        availableItemList.RemoveAt(i);
                    }
                }

                foreach (var a in _allItems)
                {
                    if (selectedSet.Contains(a)) continue;
                    var present = false;
                    foreach (var av in availableItemList)
                    {
                        if (Equals(av, a)) { present = true; break; }
                    }
                    if (!present) availableItemList.Add(a);
                }
            }
            else
            {
                var items = AvailableItemsListBox.Items;
                for (int i = items.Count - 1; i >= 0; i--)
                {
                    var it = items[i];
                    if (!InAllItems(it) || selectedSet.Contains(it))
                    {
                        items.RemoveAt(i);
                    }
                }

                foreach (var a in _allItems)
                {
                    if (selectedSet.Contains(a)) continue;
                    var present = false;
                    foreach (var av in items)
                    {
                        if (Equals(av, a)) { present = true; break; }
                    }
                    if (!present) items.Add(a);
                }
            }
        }

        private void RefreshSelectedListBoxColors()
        {
            SelectedItemsListBox?.Invalidate();
        }

        private void UpdateButtons()
        {
            if (SelectButton != null && AvailableItemsListBox != null)
            {
                SelectButton.Enabled = AvailableItemsListBox.SelectedIndex >= 0;
            }

            if (DeselectButton != null && SelectedItemsListBox != null)
            {
                DeselectButton.Enabled = SelectedItemsListBox.SelectedIndex >= 0;
            }

            if (UpButton != null && SelectedItemsListBox != null)
            {
                UpButton.Enabled = SelectedItemsListBox.SelectedIndex > 0;
            }

            if (DownButton != null && SelectedItemsListBox != null)
            {
                DownButton.Enabled = SelectedItemsListBox.SelectedIndex >= 0 && SelectedItemsListBox.SelectedIndex < SelectedItemsListBox.Items.Count - 1;
            }
        }
    }
}
