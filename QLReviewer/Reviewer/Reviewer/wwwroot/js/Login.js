//check email
function CheckEmail() {
    $.ajax({
        type: "POST",
        url: "/Account/CheckEmail",
        data: {
            email: $("#email").val()
        },
        success: function (response) {
            var message = $("#messageEmail");
            if (response) {
                message.css("color", "red");
                message.html("Email đã tồn tại");
            }
            else {
                message.css("color", "green");
                message.html("Email có thể sử dụng");
            }
        }
    });
};

function ClearMessageEmail() {
    $("#messageEmail").html("");
};