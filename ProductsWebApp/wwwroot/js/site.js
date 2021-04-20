function GetProductTable(selectedIndex, currentPage, itemsCount)
{
    $.ajax(
        {
            url: 'Home/GetProductsTable',
            type: 'POST',
            cache: false,
            data: { 'index': selectedIndex, 'currentPage': currentPage, 'itemsCount': itemsCount },
            success: function (data) {
                if (data.length > 1) {
                    $("#ProductsTable").html(data);
                }
            },
            error: function () {

            }
        });
}

function ChangeCategoryFilterItem(selectedIndex)
{
    var itemsCount = $("#ItemsCountOnPageFilterItem").val();

    GetProductTable(selectedIndex, 1, itemsCount );   
}

function ChangeItemsCount(itemsCount)
{
    var selectedCategoryIndex = $("#categoryFilterItem").val();

    GetProductTable(selectedCategoryIndex, 1, itemsCount);  
}

function ChangeCurrentPage()
{
    var maxPageCount = $("#pageCount").text();
    var currentPage = $("#currentPage").val();
    if (currentPage <= maxPageCount && currentPage>0)
    {
        var itemsCount = $("#ItemsCountOnPageFilterItem").val();
        var selectedCategoryIndex = $("#categoryFilterItem").val();
        GetProductTable(selectedCategoryIndex, currentPage, itemsCount);  
    }
}


function AddProduct()
{
    var name = $("#productName").val();
    var categoryIndex = $("#categoryFilterItemModal").val();

    $.ajax(
        {
            url: 'Home/AddProduct',
            type: 'POST',
            cache: false,
            data: { 'categoryIndex': categoryIndex, 'name': name },
            success: function (data)
            {
                if (data == "OK")
                {
                    modal.style.display = "none";

                    var itemsCount = $("#ItemsCountOnPageFilterItem").val();
                    var selectedCategoryIndex = $("#categoryFilterItem").val();
                    GetProductTable(selectedCategoryIndex, 1, itemsCount);  
                }
                else
                {
                    alert("Ошибка добавления");
                }
                
            },
            error: function ()
            {
                alert("Ошибка добавления");
            }
        });
}

// МОДАЛКА

var modal = document.getElementById("my_modal");
var btn = document.getElementById("btn_modal_window");
var span = document.getElementsByClassName("close_modal_window")[0];

btn.onclick = function () {
    modal.style.display = "block";
}

span.onclick = function () {
    modal.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}