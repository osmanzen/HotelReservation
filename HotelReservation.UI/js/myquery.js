$("#btnBook").click(function () {
    var arrivalDate = new Date($('#datepicker').val());
    var arrivalString = $('#datepicker').val();
    var departureDate = new Date($('#datepicker1').val());
    var departureString = $('#datepicker1').val();
    var durum = $("#durumSpan");
    var guestCount = $('#guestCount').val();

    function dateToStr(d) {
        var year = d.getFullYear();
        var month = d.getMonth();
        return year + "-" + (month + 1) + "-" + d.getDate();
    };
    var dtNow = new Date(dateToStr(new Date()));
    if (arrivalDate >= dtNow && arrivalString != "" && departureString != "" && arrivalDate < departureDate) {
        if (guestCount != "") {
                window.location.assign("reservation.aspx?arrival=" + arrivalString + "&departure=" + departureString + "&guestcount=" + guestCount);
        }
        else
            alert("Misafir Sayısı Giriniz..");
    }
    else {
        alert("Lütfen Geçerli Bir Tarih Seçiniz..");
    }
});