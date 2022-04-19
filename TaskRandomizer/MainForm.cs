namespace AufgabenVerteiler
{
    using System;
    using System.Data;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            try
            {
                DataTable table = new DataTable();
                table.ReadXml(System.Environment.GetEnvironmentVariable("USERPROFILE") + "/Documents/TaskRandomizer/allData.xml");
                dataTable.Columns.Remove(dataTable.Columns[dataTable.Columns.Count - 1]);
                foreach (DataColumn col in table.Columns)
                {
                    DataGridViewColumn newCol = new DataGridViewColumn();
                    newCol.HeaderText = col.ColumnName;
                    newCol.CellTemplate = new DataGridViewTextBoxCell();
                    dataTable.Columns.Add(newCol);
                    if (!col.ColumnName.Equals("ID")) roleSelection.Items.Add(col.ColumnName);
                }
                object[] cellValues = new object[dataTable.Columns.Count];
                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        cellValues[i] = row[i];
                    }
                    dataTable.Rows.Add(cellValues);
                }
            }
            catch (Exception e)
            {
            }
            dataTable.AllowUserToAddRows = true;
            DataGridViewRow newRow = new DataGridViewRow();
            dataTable.Rows.Add(newRow);
            dataTable.AllowUserToAddRows = false;
            dataTable.Rows[dataTable.Rows.Count - 1].Cells[0].Value = dataTable.Rows.Count - 1;
            dataTable.Rows.Remove(dataTable.Rows[dataTable.Rows.Count - 1]);


        }

        //*******************************************************************************************
        //**************************************Data button stuff************************************
        //*******************************************************************************************
        private void addRole_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(addRoleText.Text) || addRoleText.Text.Equals("")) return;
            String text = addRoleText.Text.Trim();
            foreach (DataGridViewColumn col in dataTable.Columns)
            {
                if (col.HeaderText.Equals(text))
                {
                    return;
                }
            }
            dataTable.AllowUserToAddRows = true;
            DataGridViewColumn newCol = new DataGridViewColumn();
            newCol.HeaderText = text;
            newCol.CellTemplate = new DataGridViewTextBoxCell();
            dataTable.Columns.Add(newCol);
            dataTable.AllowUserToAddRows = false;
        }

        private void removeRole_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(removeRoleText.Text) || removeRoleText.Text.Equals("") || removeRoleText.Text.Equals("ID")) return;
            String text = removeRoleText.Text.Trim();
            foreach (DataGridViewColumn col in dataTable.Columns)
            {
                if (col.HeaderText.Equals(text))
                {
                    dataTable.Columns.Remove(col);
                    break;
                }
            }
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            dataTable.AllowUserToAddRows = true;
            DataGridViewRow newRow = new DataGridViewRow();
            dataTable.Rows.Add(newRow);
            dataTable.AllowUserToAddRows = false;
            dataTable.Rows[dataTable.Rows.Count-1].Cells[0].Value = dataTable.Rows.Count - 1;
        }

        private void removeRow_Click(object sender, EventArgs e)
        {
            int currentIndex = dataTable.Rows.Count -1;
            if (dataTable.SelectedRows.Count != 0)
            {
                currentIndex = dataTable.SelectedRows[0].Index; dataTable.Rows.Remove(dataTable.SelectedRows[0]);
            }
            else if (dataTable.SelectedCells.Count != 0)
            {
                currentIndex = dataTable.SelectedCells[0].RowIndex; dataTable.Rows.Remove(dataTable.Rows[dataTable.SelectedCells[0].RowIndex]);
            }
            else if (dataTable.Rows.Count != 0) dataTable.Rows.Remove(dataTable.Rows[dataTable.Rows.Count - 1]);
            int counter = currentIndex;
            foreach (DataGridViewRow row in dataTable.Rows)
            {
                if (Int32.Parse(row.Cells[0].Value.ToString()) > currentIndex)
                {
                    row.Cells[0].Value = counter;
                    counter++;
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.TableName = "main";
            roleSelection.Items.Clear();
            foreach (DataGridViewColumn col in dataTable.Columns)
            {
                table.Columns.Add(col.HeaderText);
                if(!col.HeaderText.Equals("ID")) roleSelection.Items.Add(col.HeaderText);
            }

            object[] cellValues = new object[dataTable.Columns.Count];
            foreach (DataGridViewRow row in dataTable.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                table.Rows.Add(cellValues);
            }
            if (!Directory.Exists(System.Environment.GetEnvironmentVariable("USERPROFILE") + "/Documents/TaskRandomizer"))
            {
                Directory.CreateDirectory(System.Environment.GetEnvironmentVariable("USERPROFILE") + "/Documents/TaskRandomizer");
            }
            table.WriteXml(System.Environment.GetEnvironmentVariable("USERPROFILE")+ "/Documents/TaskRandomizer/allData.xml", XmlWriteMode.WriteSchema);
        }

        private void roll_Click(object sender, EventArgs e)
        {
            if (rollCount.Value <= 0 || roleSelection.SelectedItem == null || String.IsNullOrWhiteSpace(roleSelection.SelectedItem.ToString()) || roleSelection.SelectedItem.ToString().Equals("")) return;
            
            Random random = new Random();
            bool selected = false;
            List<string> selectedItems = new List<string>();
            List<string> possibleSelections = new List<string>();
            rollDisplay.Text = "";
            foreach (DataGridViewRow row in dataTable.Rows)
            {
                possibleSelections.AddRange(row.Cells
                    .OfType<DataGridViewCell>()
                    .Where(cell => dataTable.Columns[cell.ColumnIndex].HeaderText.Equals(roleSelection.SelectedItem.ToString()) && cell.Value != null)
                    .Select(cell => cell.Value.ToString()).ToList());
            }
            if(rollCount.Value >= possibleSelections.Count)
            {
                selected = true;
                selectedItems = possibleSelections;
            }
            while (!selected)
            {
                int randInt = random.Next(possibleSelections.Count);
                if(!String.IsNullOrWhiteSpace(possibleSelections[randInt]) && !possibleSelections[randInt].Equals("")) selectedItems.Add(possibleSelections[randInt]);
                possibleSelections.RemoveAt(randInt);
                if (selectedItems.Count == rollCount.Value || possibleSelections.Count == 0) selected = true;
            }
            foreach(string item in selectedItems)
            {
                rollDisplay.Text = rollDisplay.Text + item + "\n";
            }
        }
    }
}