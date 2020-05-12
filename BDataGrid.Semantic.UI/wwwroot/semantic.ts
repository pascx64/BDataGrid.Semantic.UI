declare var $: any;
namespace BDataGrid.Semantic.UI {
    export function InitializePopups(tableRef: HTMLBaseElement) {

        $(tableRef).find('th').popup();

    }
}