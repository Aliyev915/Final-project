$(document).ready(function () {
    //Search
    $('#search').keyup(function () {
        let search = $(this).val();
        $.ajax({
            url: '/Blog/Search?search=' + search,
            type: 'Get',
            success: function (response) {
                $('.blogs').remove();
                $('.blog-side .col-lg-8').prepend(response);
                if (search != "") {
                    window.history.pushState('', '', '/Blog/Search?search=' + search);
                    $('.pagination').hide();
                } else {
                    window.history.pushState('', '', '/Blog');
                    $('.pagination').show();
                }
            }
        })
    })
    $('#employer').keyup(function () {
        let search = $(this).val();
        $.ajax({
            url: '/Employer/Search?search=' + search,
            type: 'Get',
            success: function (response) {
                $('.employers').remove();
                $('.col-lg-9 .right-section').append(response);
                console.log(response);
                if (search != "") {
                    window.history.pushState('', '', '/Employer/Search?search=' + search);
                    $('.pagination').hide();
                } else {
                    window.history.pushState('', '', '/Employer');
                    $('.pagination').show();
                }
            }
        })
    })
    $('#sort').change(function () {
        let sort = $(this).val();
        $.ajax({
            url: '/' + controller + '/Sort?sort=' + sort,
            type: 'Get',
            success: function (response) {
                $('.' + controller.toLowerCase() + 's').remove();
                $('.right-section').append(response);
            }
        })
    })

    let controller = $('#controller').val();
    let action = $('#action').val();
    if (controller == 'Job' && action == 'SearchFromHome') {
        window.history.pushState('', '', '/Job');
    }
    $('.findJob').click(function (e) {
        let search = $('#job').val();
        let route = '/Job/SearchFromHome?search=' + search + '&location=' + inputLoc.val();
        window.location.replace(route);

    });

    let searchInput = $('.left-section .form-control');
    let select1 = $('.js-example-basic-single').eq(0);
    let select2 = $('.js-example-basic-single').eq(1);
    let type = $('input:radio[name=jobType]');
    let date = $('input:radio[name=DataPosted]');
    let experience = $('input:radio[name=Experince]');
    let salary = $('input:radio[name=Salary]');
    let checkedDate = $('input:radio[name=DataPosted]:checked').val();
    let checkedType = $('input:radio[name=jobType]:checked').val();
    let checkedExp = $('input:radio[name=Experince]:checked').val();
    let checkedSalary = $('input:radio[name=Salary]:checked').val();
    searchInput.keyup(function (e) {
        let text = $(this).val();
        let route = '/' + controller + '/Search?text=' + text + '&location=' + select1.val() + '&category=' + select2.val() +
            '&type=' + checkedType + '&date=' + checkedDate +
            '&experience=' + checkedExp + '&salary=' + checkedSalary;
        $.ajax({
            url: route,
            type: 'Get',
            success: function (response) {
                $('.jobs').remove();
                $('.col-lg-8 .right-section').append(response);
            }
        })
    })
    select1.change(function () {
        let location = $(this).val();
        let route = '/' + controller + '/Search?text=' + searchInput.val() + '&location=' + location + '&category=' + select2.val() +
            '&type=' + checkedType + '&date=' + checkedDate +
            '&experience=' + checkedExp + '&salary=' + checkedSalary;
        $.ajax({
            url: route,
            type: 'Get',
            success: function (response) {
                $('.jobs').remove();
                $('.col-lg-8 .right-section').append(response);
            }
        })

    });
    select2.change(function () {
        let category = $(this).val();
        let route = '/' + controller + '/Search?text=' + searchInput.val() + '&location=' + select1.val() + '&category=' + category +
            '&type=' + checkedType + '&date=' + checkedDate +
            '&experience=' + checkedExp + '&salary=' + checkedSalary;
        $.ajax({
            url: route,
            type: 'Get',
            success: function (response) {
                $('.jobs').remove();
                $('.col-lg-8 .right-section').append(response);
            }
        })
    });

    type.change(function () {
        let route = '/' + controller + '/Search?text=' + searchInput.val() + '&location=' +
            select1.val() + '&category=' + select2.val() + '&type=' + $(this).val() + '&date=' + checkedDate +
            '&experience=' + checkedExp + '&salary=' + checkedSalary;
        $.ajax({
            url: route,
            type: 'Get',
            success: function (response) {
                $('.jobs').remove();
                $('.col-lg-8 .right-section').append(response);
            }
        })
    });
    date.change(function () {
        let route = '/' + controller + '/Search?text=' + searchInput.val() + '&location=' +
            select1.val() + '&category=' + select2.val() + '&type=' + checkedType + '&date=' + $(this).val() +
            '&experience=' + checkedExp + '&salary=' + checkedSalary;
        $.ajax({
            url: route,
            type: 'Get',
            success: function (response) {
                $('.jobs').remove();
                $('.col-lg-8 .right-section').append(response);
            }
        })
    });
    experience.change(function () {
        let route = '/' + controller + '/Search?text=' + searchInput.val() + '&location=' +
            select1.val() + '&category=' + select2.val() + '&type=' + checkedType + '&date=' + checkedDate +
            '&experience=' + $(this).val() + '&salary=' + checkedSalary;
        $.ajax({
            url: route,
            type: 'Get',
            success: function (response) {
                $('.jobs').remove();
                $('.col-lg-8 .right-section').append(response);
            }
        })
    });
    salary.change(function () {
        let route = '/' + controller + '/Search?text=' + searchInput.val() + '&location=' +
            select1.val() + '&category=' + select2.val() + '&type=' + checkedType + '&date=' + checkedDate +
            '&experience=' + checkedExp + '&salary=' + $(this).val();
        $.ajax({
            url: route,
            type: 'Get',
            success: function (response) {
                $('.jobs').remove();
                $('.col-lg-8 .right-section').append(response);
            }
        })
    });
    //Search
})