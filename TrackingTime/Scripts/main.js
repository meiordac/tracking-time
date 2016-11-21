$(function() {
    // This will make every element with the class "date-picker" into a DatePicker element
    $('.date-picker')
        .datetimepicker({
            showTodayButton: true,
            format: 'YYYY-MM-DD HH:mm',
            showClose: true,
            showClear: true,
            toolbarPlacement: 'top',
            stepping: 15
        });

    $('.table')
        .DataTable(
            {
                dom: 'Bfrtip',
                buttons: [
                    {
                        extend: 'copyHtml5',
                        exportOptions: {
                            columns: [':visible :not(:last-child)']
                        }
                    },
                    {
                        extend: 'excelHtml5',
                        exportOptions: {
                            columns: [':visible :not(:last-child)']
                        }

                    },
                    {
                        extend: 'csvHtml5',
                        exportOptions: {
                            columns: [':visible :not(:last-child)']
                        }
                    }
                ]

            }
        );
});