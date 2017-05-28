
function validationform() {
    return false;
}
function validation() {
    var userName = document.getElementsByName("username")[0].value;
    var passWord = document.getElementsByName("password")[0].value;
    if (userName != '' && passWord != '') {
        LoadKhachHang(userName, passWord);
    }
    else
        swal("Nhập đầy đủ Tên đăng nhập và Mật khẩu!");
}

function LoadKhachHang(userName, passWord) {
    _url = 'http://localhost:54153/api/nhanvien/dangnhap';
    var dataToPost={        
	    TaiKhoan: userName,
        MatKhau: passWord        
    }
    var jsonToPost = JSON.stringify(dataToPost);
    $.ajax({
        type: 'POST',
        data: jsonToPost,
        url: _url,
        dataType: 'json',
        contentType: 'application/json',
        timeout: 30 * 1000,
        async: false
    })
    .done(function (data, statusText, xhr) {
        console.log(xhr.status);
        if (xhr.status == 200)
        {
            localStorage.setItem("isDangNhap", true);
            Cookies.set('username', data[0].HoTen);            
            window.location.href = "index.html";                      
        }  
    })
    .fail(function (jqXHR, textStatus, error) {
        console.log(jqXHR);
        console.log(jqXHR.statusCode);
        if (jqXHR.status == 201)
        {
            sweetAlert("Oops...", "Sai Tên đăng nhập hoặc Mật khẩu!", "error");
        }
        else
            sweetAlert("Oops...", "Lỗi không kết nối được đến máy chủ Api!", "error");
    });
}

/*$.each(data, function (index, dm) {

});*/

