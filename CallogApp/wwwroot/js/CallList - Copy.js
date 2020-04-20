var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/call",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "caller", "width": "20%" },
            { "data": "receiver", "width": "20%" },
            { "data": "suject", "width": "20%" },
            { "data": "createDate", "width": "20%" },
            { "data": "id","render": function (data) { return `<div class="text-center">
             <a href="/Admin/Calls/Edit/${data}" class='btn btn-success text-white style='cursor:pointer; width:70px;'>Edit</a>&nbsp<a class='btn btn-danger text-white style='cursor:pointer; width:70px;' onclick=Delete('/api/call?id='+${data})>Delete</a></div>`;
                }, "width": "40%"
            }

        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width": "100%"
    });
}

function Delete(url) {
    swal({
        title: "Are you sure?",
        text: "Once deleted, you will not able to recover",
        icon: "warning",
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}