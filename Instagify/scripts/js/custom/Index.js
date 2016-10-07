var m_lblTitle = $("#m_lblTitle");
var m_imgPhoto = $("#m_imgPhoto");
var m_address = $("#m_address");
var m_phone = $("#m_phone");
var m_lblSubTitle = $("#m_lblSubTitle");
var m_time = null;
var m_txtComment = $("#ContentPlaceHolder1_m_txtComment");
$(document).ready(function () {
    $('[data-toggle="popover"]').popover();
    $("#m_SendComment").on("click", function ()
    {
  
        var obj = {
            Descrip: m_txtComment.val(),
            IdComment:null, 
            IdUser :null,
           IdContest :null,
      CreatedOn :null
        }


        var dataJson = JSON.stringify({ obj });
        $.ajax(
              {
                  type: "POST",
                  url: "Index.aspx/InsertCommentContest",
                  data: dataJson,
                  dataType: "json",
                  contentType: "application/json; charset=utf-8",
                  success: OnSuccess,
                  failure: function (response)
                  {
                      alert(response.d);
                  },
                  error: function (response)
                  {
                      alert(response.d);
                  }
              });
        function OnSuccess(response)
        {
            alert(response.d);
        }

    });





    $.ajax(
          {
              type: "POST",
              url: "Index.aspx/GetLastActiveContest",
             
              dataType: "json",
              contentType: "application/json; charset=utf-8",
              success: OnSuccess,
              failure: function (response) {
                  alert(response.d);
              },
              error: function (response) {
                  alert(response.d);
              }
          });
        function OnSuccess(response) {
            var a = JSON.stringify(response.d);
            m_lblTitle.text(response.d[0]["Title"]);
            m_lblSubTitle.text(response.d[0]["SubTitle"]);
            m_imgPhoto.attr("src", "../imagenes/" + response.d[0]["Photo"]);
            m_address.text(response.d[0]["Addres"]);
            m_phone.text(response.d[0]["Phone"]);
            m_time = (response.d[0]["EndDay"]);


            var timer;
            
            var compareDate = new Date(parseInt(m_time.substr(6)));
            compareDate.setDate(compareDate.getDate());

            timer = setInterval(function () {
                timeBetweenDates(compareDate);
            }, 1000);

            function timeBetweenDates(toDate) {
                var dateEntered = toDate;
                var now = new Date();
                var difference = dateEntered.getTime() - now.getTime();

                if (difference <= 0)
                {

                    // Timer done
                    clearInterval(timer);

                } else
                {

                    var seconds = Math.floor(difference / 1000);
                    var minutes = Math.floor(seconds / 60);
                    var hours = Math.floor(minutes / 60);
                    var days = Math.floor(hours / 24);

                    hours %= 24;
                    minutes %= 60;
                    seconds %= 60;

                    $("#days").text(days);
                    $("#hours").text(hours);
                    $("#minutes").text(minutes);
                    $("#seconds").text(seconds);
                }
            }


        };

        //$.ajax(
        //     {
        //         type: "POST",
        //         url: "Index.aspx/GetTotals",

        //         dataType: "json",
        //         contentType: "application/json; charset=utf-8",
        //         success: OnSuccess,
        //         failure: function (response)
        //         {
        //             alert(response.d);
        //         },
        //         error: function (response)
        //         {
        //             alert(response.d);
        //         }
        //     });
        //function OnSuccess(response)
        //{
        //    var a = JSON.stringify(response.d);
        //    //m_lblTitle.text(response.d[0]["Title"]);
        //    //m_lblSubTitle.text(response.d[0]["SubTitle"]);
        //    //m_imgPhoto.attr("src", "../imagenes/" + response.d[0]["Photo"]);
        //    //m_address.text(response.d[0]["Addres"]);
        //    //m_phone.text(response.d[0]["Phone"]);
        //    //m_time = (response.d[0]["EndDay"]);


        //    //var timer;

        //    //var compareDate = new Date(parseInt(m_time.substr(6)));
        //    //compareDate.setDate(compareDate.getDate());

        //    //timer = setInterval(function ()
        //    //{
        //    //    timeBetweenDates(compareDate);
        //    //}, 1000);

        //    //function timeBetweenDates(toDate)
        //    //{
        //    //    var dateEntered = toDate;
        //    //    var now = new Date();
        //    //    var difference = dateEntered.getTime() - now.getTime();

        //    //    if (difference <= 0)
        //    //    {

        //    //        // Timer done
        //    //        clearInterval(timer);

        //    //    } else
        //    //    {

        //    //        var seconds = Math.floor(difference / 1000);
        //    //        var minutes = Math.floor(seconds / 60);
        //    //        var hours = Math.floor(minutes / 60);
        //    //        var days = Math.floor(hours / 24);

        //    //        hours %= 24;
        //    //        minutes %= 60;
        //    //        seconds %= 60;

        //    //        $("#days").text(days);
        //    //        $("#hours").text(hours);
        //    //        $("#minutes").text(minutes);
        //    //        $("#seconds").text(seconds);
        //    //    }
        //    //}


        //};

});
