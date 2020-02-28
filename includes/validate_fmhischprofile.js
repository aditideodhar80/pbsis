
function checkRequired(formobj) {
    // Enter name of mandatory fields
    var fieldRequired = Array("ctl00_ContentPlaceHolder1_txtSchoolName", "ctl00_ContentPlaceHolder1_txtSchoolID", "ctl00_ContentPlaceHolder1_ddlSchoolDistrict", "ctl00_ContentPlaceHolder1_txtSchoolStreetAddress1", "ctl00_ContentPlaceHolder1_txtSchoolCity", "ctl00_ContentPlaceHolder1_txtSchoolState", "ctl00_ContentPlaceHolder1_txtSchoolZip", "ctl00_ContentPlaceHolder1_txtSchoolPhone01", "ctl00_ContentPlaceHolder1_txtSchoolPhone02", "ctl00_ContentPlaceHolder1_txtSchoolPhone03", "ctl00_ContentPlaceHolder1_txtSchoolFax01", "ctl00_ContentPlaceHolder1_txtSchoolFax02", "ctl00_ContentPlaceHolder1_txtSchoolFax03", "ctl00_ContentPlaceHolder1_txtSchoolAdministratorName", "ctl00_ContentPlaceHolder1_txtSchoolAdministratorPhone01", "ctl00_ContentPlaceHolder1_txtSchoolAdministratorPhone02", "ctl00_ContentPlaceHolder1_txtSchoolAdministratorPhone03", "ctl00_ContentPlaceHolder1_txtSchoolAdministratorEmail", "ctl00_ContentPlaceHolder1_ddlSchoolType");

    // Enter field description to appear in the dialog box
    var fieldDescription = Array("School Name", "School Id", "School District", "School Street Address", "School City", "School State", "School Zip", "School Phone Number (Area Code)", "School Phone Number (Prefix)", "School Phone Number (Suffix)", "School Fax Number (Area Code)", "School Fax Number (Prefix)", "School Fax Number (Suffix)", "School Administrator's Name", "School Administrator's Phone Number (Area Code)", "School Administrator's Phone Number (Prefix)", "School Administrator's Phone Number (Suffix)", "School Administrator's Email Address", "School Type");
    // dialog message


    var alertMsg = "Please complete the following fields:\n\n";

    var l_Msg = alertMsg.length;

    for (var i = 0; i < fieldRequired.length; i++) {
        var obj = document.forms[0].elements[fieldRequired[i]];
        if (obj) {
            switch (obj.type) {
                case "select-one":
                    if (obj.selectedIndex == 0 || obj.options[obj.selectedIndex].value == "" || obj.options[obj.selectedIndex].value == "X9X") {
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

    if (alertMsg.length == l_Msg) {
        return true;
    }
    else {
        alert(alertMsg);
        return false;
    }
}


function checkIfNum(formobj) {
    // Enter name of all fields
    var fieldValues = Array("ctl00_ContentPlaceHolder1_txtSchoolZip", "ctl00_ContentPlaceHolder1_txtSchoolPhone01", "ctl00_ContentPlaceHolder1_txtSchoolPhone02", "ctl00_ContentPlaceHolder1_txtSchoolPhone03", "ctl00_ContentPlaceHolder1_txtSchoolFax01", "ctl00_ContentPlaceHolder1_txtSchoolFax02", "ctl00_ContentPlaceHolder1_txtSchoolFax03", "ctl00_ContentPlaceHolder1_txtSchoolAdministratorPhone01", "ctl00_ContentPlaceHolder1_txtSchoolAdministratorPhone02", "ctl00_ContentPlaceHolder1_txtSchoolAdministratorPhone03");
    // Enter field description to appear in the dialog box
    var fieldDescription = Array("School Zip Code", "School Phone Number (Area Code)", "School Phone Number (Prefix)", "School Phone Number (Suffix)", "School Fax Number (Area Code)", "School Fax Number (Prefix)", "School Fax Number (Suffix)", "School Administrator's Phone Number (Area Code)", "School Administrator's Phone Number (Prefix)", "School Administrator's Phone Number (Suffix)");


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
        return true;
    }
    else {
        alert(alertMsg);
        return false;
    }

}



function checkFormfmhischprf(formobj) {
    if (checkRequired(formobj) == false)
    { return false; }
    else {
        if (checkIfNum(formobj) == false) {
            return false;
        }
        else {
            if (checkEmail(formobj) == false)
            { return false; }
            else
            { return true; }
        }
    }
}


function checkEmail(formobj) {

    var str = document.forms[0].elements["ctl00_ContentPlaceHolder1_txtSchoolAdministratorEmail"].value;

    var at = "@";
    var dot = ".";
    var lat = str.indexOf(at);
    var lstr = str.length;
    var ldot = str.indexOf(dot);


    if ((str == null) || (str == "")) {
        alert("Please Enter your Email ID");
        return false;
    }


    if (str.indexOf(at) == -1) {
        alert("Invalid E-mail ID");
        return false;
    }

    if (str.indexOf(at) == -1 || str.indexOf(at) == 0 || str.indexOf(at) == lstr) {
        alert("Invalid E-mail ID");
        return false;
    }

    if (str.indexOf(dot) == -1 || str.indexOf(dot) == 0 || str.indexOf(dot) == lstr) {
        alert("Invalid E-mail ID");
        return false;
    }

    if (str.indexOf(at, (lat + 1)) != -1) {
        alert("Invalid E-mail ID");
        return false;
    }

    if (str.substring(lat - 1, lat) == dot || str.substring(lat + 1, lat + 2) == dot) {
        alert("Invalid E-mail ID");
        return false;
    }

    if (str.indexOf(dot, (lat + 2)) == -1) {
        alert("Invalid E-mail ID");
        return false;
    }

    if (str.indexOf(" ") != -1) {
        alert("Invalid E-mail ID");
        return false;
    }

    return true;
}
