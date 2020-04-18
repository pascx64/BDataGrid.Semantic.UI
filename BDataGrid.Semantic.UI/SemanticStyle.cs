using System;
using System.Collections.Generic;
using System.Text;

namespace BDataGrid.Semantic.UI
{
    public class SemanticStyle : Library.IBDataGridStyle
    {
        public string TableClass { get; set; } = "ui celled structured table";
        public string RowClass { get; set; } = "";
        public string CellClass { get; set; } = "";
        public string HeaderClass { get; set; } = "";
        public string HeaderRowClass { get; set; } = "";

        public string SelectedCell { get; set; } = "selectedCell";
    }
}
