

function checkformODS(formobj) {
   //alert('in checkform');
    if (checkRequired(formobj) == false)
 
    { return false; }
    else {
        if (checkIfNum(formobj) == false)
        { return false; }
        else {
            if (checkNumbers(formobj) == false)
            { return false; }
            else {
                //submitonce(document.forms[0]);
                return true;
            }
        }
    }
}


function checkRange(objValue, range) {
    var lowerBound, upperBound, number;
    lowerBound = parseInt(range.substring(0, range.indexOf('-')));
    upperBound = parseInt(range.substring(range.indexOf('-') + 1));
    number = parseInt(objValue);

    if ((objValue != "") && (isNaN(number) == false) && (number >= lowerBound) && (number <= upperBound))
    { return true; }
    else
    { return false; }
}


function checkIfNum(formobj) {
    // Enter name of all fields
    var fieldValues = Array("ctl00_ContentPlaceHolder1_txtOdTotalSchoolDays", "ctl00_ContentPlaceHolder1_txtOdAvgDailyAttendance", "ctl00_ContentPlaceHolder1_txtOdTotalOfficeReferrals", "ctl00_ContentPlaceHolder1_txtOdTotalISSDays", "ctl00_ContentPlaceHolder1_txtOdTotalOSSDays");
    // Enter field description to appear in the dialog box
    var fieldDescription = Array("Total Number of School Days", "Average Daily Attendance", "Total Number of Office Discipline Referrals", "Total Number of Days of In-School Suspensions", "Total Number of Days of Out-Of-School Suspensions");


    var alertMsg = "The following fields require numerical entries:\n\n";
    var l_Msg = alertMsg.length;

    for (var i = 0; i < fieldValues.length; i++) {
        var obj = document.forms[0].elements[fieldValues[i]];
        if (obj) {
            if (obj.value != "" && obj.value != null) {
                if (isNaN(obj.value)) {
                    alertMsg += " - " + fieldDescription[i] + "\n";
                }
            }
        }
    }

    if (alertMsg.length == l_Msg) {
        //submitonce(formobj);
        return true;
    }
    else {
        alert(alertMsg);
        //alert("Please respond to all questions before moving further");
        return false;
    }
}


function checkNumbers(formobj) {
    // Enter name of mandatory fields
    var fieldValues = Array("ctl00_ContentPlaceHolder1_txtOdTotalSchoolDays", "ctl00_ContentPlaceHolder1_txtOdAvgDailyAttendance");
    // Enter the range of the variable
    var fieldRange = Array("0-200", "0-100");
    // Enter field description to appear in the dialog box
    var fieldDescription = Array("Total Number of School Days", "Average Daily Attendance");

    var alertMsg = "Please enter a number within the proper range for:\n\n";
    var l_Msg = alertMsg.length;
    var passed = true;

    for (var i = 0; i < fieldValues.length; i++) {
        var obj = document.forms[0].elements[fieldValues[i]];
        if (obj) {
            if (obj.value != "") {
                passed = checkRange(obj.value, fieldRange[i]);
                if (passed == false) {
                    alertMsg += " - " + fieldDescription[i] + " (" + fieldRange[i] + ") \n";
                }
            }
        }
    }

    if (alertMsg.length == l_Msg) {
        return true;
    }
    else {
        alert(alertMsg);
        return false;
    }
}


function checkRequired(formobj) {
    // Enter name of mandatory fields

    //alert('aaa');
    var fieldRequired = Array("ctl00_ContentPlaceHolder1_txtOdTotalSchoolDays", "ctl00_ContentPlaceHolder1_txtOdTotalOfficeReferrals", "ctl00_ContentPlaceHolder1_txtOdTotalISSDays", "ctl00_ContentPlaceHolder1_txtOdTotalOSSDays");
    // Enter field description to appear in the dialog box
    var fieldDescription = Array("Total Number of School Days", "Total Number of Office Discipline Referrals", "Total Number of Days of In-School Suspension", "Total Number of Days of Out-of-School Suspensions");
    // dialog message

    var alertMsg = "Please complete the following fields:\n\n";
    var l_Msg = alertMsg.length;


    var l_Msg = alertMsg.length;

    for (var i = 0; i < fieldRequired.length; i++) {
        var obj = document.forms[0].elements[fieldRequired[i]];
        if (obj) {
            switch (obj.type) {
                case "select-one":
                    if (obj.selectedIndex == 0 || obj.options[obj.selectedIndex].value == "") {
                        alertMsg += " - " + fieldDescription[i] + "\n";
                    }
                    break;
                case "select-multiple":
                    if (obj.selectedIndex == -1) {
                        alertMsg += " - " + fieldDescription[i] + "\n";
                    }
                    break;
                case "text":
                case "textarea":
                    if (obj.value == "" || obj.value == null) {
                        alertMsg += " - " + fieldDescription[i] + "\n";
                    }
                    break;
                default:
            }
            if (obj.type == undefined) {
                var blnchecked = false;
                for (var j = 0; j < obj.length; j++) {
                    if (obj[j].checked) {
                        blnchecked = true;
                    }
                }
                if (!blnchecked) {
                    alertMsg += " - " + fieldDescription[i] + "\n";
                }
            }
        }
    }


    var rbchecked = false

    var obj = document.forms[0].elements["ctl00$ContentPlaceHolder1$grpTier2"];
   
    for (var j = 0; j < obj.length; j++) {
        if (obj[j].checked) {
            rbchecked = true
            if (obj[j].value == 1) {
                var objtext = document.forms[0].elements["ctl00_ContentPlaceHolder1_txtOdProgMonTargDesc"];
                //alert(objtext);
                if (objtext.value == "") {
                    alertMsg += " - Describe progress monitoring tools used for targeted group students" + "\n";
                }
            }
        }
    }

    if (!rbchecked) {
        alertMsg += " - Indicate if progress monitoring tools used for targeted group students" + "\n";
    }

    rbchecked = false
    var obj = document.forms[0].elements["ctl00$ContentPlaceHolder1$grpTier3"];
    for (var j = 0; j < obj.length; j++) {
        if (obj[j].checked) {
            rbchecked = true

            if (obj[j].value == 1) {
                var objtext = document.forms[0].elements["ctl00_ContentPlaceHolder1_txtOdProgMonIndDesc"];
                if (objtext.value == "") {
                    alertMsg += " - Describe progress monitoring tools used for individual students" + "\n";
                }
            }
        }
    }

    if (!rbchecked) {
        alertMsg += " - Indicate if progress monitoring tools used for individual students" + "\n";
    }

    if (alertMsg.length == l_Msg) {
        //submitonce(formobj);
        return true;
    }
    else {
        alert(alertMsg);
        //alert("Please respond to all questions before moving further");
        return false;
    }
}


function sftest(formobj) {

    var obj = document.forms[0].elements["OdProgMonIndiv"];

    for (var j = 0; j < obj.length; j++) {
        if (obj[j].checked) {
            if (obj[j].value == 1) {
                var objtext = document.forms[0].elements["OdProgMonIndDesc"];
                if (objtext.value == "") {
                    alert("No description Provided");
                }
            }
        }
    }


}