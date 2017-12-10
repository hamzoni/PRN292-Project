using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectCSharp.Utility
{
    class UIHelper
    {
        public static List<int> getSelectedIndices(DataGridView dgv)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < dgv.SelectedCells.Count; i++)
            {
                indices.Add(dgv.SelectedCells[i].RowIndex);
            }
            return indices;
        }

        public static void removeBorderButton(params Button[] btns)
        {
            foreach (Button b in btns)
            {
                b.TabStop = false;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
            }
        }
    }
}
