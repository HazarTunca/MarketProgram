using System.Windows.Forms;

namespace XIV.Utils
{
    /// <summary>
    /// Utilities for <see cref="DataGridView"/> class
    /// </summary>
    public static class DataGridUtils
    {
        /// <summary>
        /// Creates a new column with giving <paramref name="DataPropertyName"/> and <paramref name="Header"/> 
        /// and returns it
        /// </summary>
        /// <param name="DataPropertyName"></param>
        /// <param name="Header"></param>
        /// <returns>A new <see cref="DataGridViewColumn"/></returns>
        public static DataGridViewColumn CreateColumn(string DataPropertyName, string Header,
            DataGridViewAutoSizeColumnMode autoSizeMode = DataGridViewAutoSizeColumnMode.Fill)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.Name = DataPropertyName;
            column.DataPropertyName = DataPropertyName;
            column.HeaderText = Header;

            column.AutoSizeMode = autoSizeMode;
            return column;
        }

        // TODO : Accept DataGridViewCell
        public static DataGridViewRow CreateRow(int cellCount, bool isReadOnly)
        {
            DataGridViewRow row = new DataGridViewRow();
            for (int i = 0; i < cellCount; i++)
			{
                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells[i].ReadOnly = isReadOnly;
			}
            return row;
        }
    }

}