using System;
using System.Collections.Generic;
using System.Text;

namespace BDataGrid.Semantic.UI
{
    public class SemanticStyle : Library.IBDataGridStyle
    {
        public string TableClass { get; set; } = "ui sortable celled structured table";

        public string RowClass { get; set; } = "";

        public string CellClass { get; set; } = "";

        public string HeaderClass { get; set; } = "";

        public string HeaderRowClass { get; set; } = "";

        public string SelectedCell { get; set; } = "selectedCell";

        public string PaginationDivClass { get; set; } = "ui right floated pagination menu";

        public string PaginationPageNumberClass { get; set; } = "icon item";

        public string PaginationLeftIcon { get; set; } = "angle double left icon";

        public string PaginationRightIcon { get; set; } = "angle double right icon";

        public string HeaderSortedAscendingClass { get; set; } = "sorted ascending";

        public string HeaderSortedDescendingClass { get; set; } = "sorted descending";

        public string ExportExcelDivClass { get; set; } = "ui right floated pagination menu";

        public string ExportExcelAClass { get; set; } = "icon item excelIconContainer";

        public string ExportExcelIconClass { get; set; } = "large green file excel outline icon";

        public string? PopupInitializationJavascriptFunction { get; set; } = "BDataGrid.Semantic.UI.InitializePopups";
    }
}
