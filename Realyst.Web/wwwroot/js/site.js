

$(document).ready(function () {
    $("#tbl-product-details").DataTable({
        processing: true,
        ordering: true,
        paging: true,
        orderMulti: false, 
        searching: true,
        ajax: "https://localhost:7135/api/Product/GetProductsList",
        columns: [
            { "data": "productId", "name": "ProductId", "autoWidth": true },
            { "data": "productName", "name": "ProductName", "autoWidth": true },
            { "data": "price", "name": "Price", "autoWidth": true },
            { "data": "releaseDate", "name": "ReleaseDate", "autoWidth": true },
        ]
    });
});  


