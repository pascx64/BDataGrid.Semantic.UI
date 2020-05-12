var BDataGrid;
(function (BDataGrid) {
    var Semantic;
    (function (Semantic) {
        var UI;
        (function (UI) {
            function InitializePopups(tableRef) {
                $(tableRef).find('th').popup();
            }
            UI.InitializePopups = InitializePopups;
        })(UI = Semantic.UI || (Semantic.UI = {}));
    })(Semantic = BDataGrid.Semantic || (BDataGrid.Semantic = {}));
})(BDataGrid || (BDataGrid = {}));
//# sourceMappingURL=semantic.js.map