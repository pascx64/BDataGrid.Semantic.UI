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

        public string PaginationDivClass { get; set; } = "ui right floated pagination menu";

        public string PaginationPageNumberClass { get; set; } = "icon item";

        public string PaginationLeftIcon { get; set; } = "angle double left icon";

        public string PaginationRightIcon { get; set; } = "angle double right icon";
    }
}
