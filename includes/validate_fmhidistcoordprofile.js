function checkFMHIRequired(formobj) {
    // Enter name of mandatory fields
    var fieldRequired = Array("ctl00_ContentPlaceHolder1_ddlSchoolDistrict", "ctl00_ContentPlaceHolder1_txtDistrictName", "ctl00_ContentPlaceHolder1_txtDistrictID", "ctl00_ContentPlaceHolder1_txtCoordFirstName_2", "ctl00_ContentPlaceHolder1_txtCoordLastName_2", "ctl00_ContentPlaceHolder1_txtStreetAddress1", "ctl00_ContentPlaceHolder1_txtDistrictCity", "ctl00_ContentPlaceHolder1_txtDistrictState", "ctl00_ContentPlaceHolder1_txtDistrictZip", "ctl00_ContentPlaceHolder1_txtDistrictPhone01", "ctl00_ContentPlaceHolder1_txtDistrictPhone02", "ctl00_ContentPlaceHolder1_txtDistrictPhone03", "ctl00_ContentPlaceHolder1_txtDistrictFax01", "ctl00_ContentPlaceHolder1_txtDistrictFax02", "ctl00_ContentPlaceHolder1_txtDistrictFax03", "ctl00_ContentPlaceHolder1_txtDistrictCell01", "ctl00_ContentPlaceHolder1_txtDistrictCell02", "ctl00_ContentPlaceHolder1_txtDistrictCell03", "ctl00_ContentPlaceHolder1_txtDistrictCoordEmail_2");

    // Enter field description to appear in the dialog box
    var fieldDescription = Array("Select District","District Name", "District Id", "District Coordinator's First Name", "District Coordinator's Last Name", "District Street Address", "District City", "District State", "District Zip Code", "District Phone Number (Area Code)", "District Phone Number (Prefix)", "District Phone Number (Suffix)", "District Fax Number (Area Code)", "District Fax Number (Prefix)", "District Fax Number (Suffix)", "District Cell Number (Area Code)", "District Cell Number (Prefix)", "District Cell Number (Suffix)", "District Coordinator's Email");
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


function checkFMHIIfNum(formobj) {
    // Enter name of all fields
    var fieldValues = Array("ctl00_ContentPlaceHolder1_txtDistrictZip", "ctl00_ContentPlaceHolder1_txtDistrictPhone01_2", "ctl00_ContentPlaceHolder1_txtDistrictPhone02_2", "ctl00_ContentPlaceHolder1_txtDistrictPhone03_2", "ctl00_ContentPlaceHolder1_txtDistrictFax01_2", "ctl00_ContentPlaceHolder1_txtDistrictFax02_2", "ctl00_ContentPlaceHolder1_txtDistrictFax03_2", "ctl00_ContentPlaceHolder1_txtDistrictCell01_2", "ctl00_ContentPlaceHolder1_txtDistrictCell02_2", "ctl00_ContentPlaceHolder1_txtDistrictCell03_2");
    // Enter field description to appear in the dialog box
    var fieldDescription = Array("District Coordinator's Zip Code", "Secondary District Coordinator's Phone Number (Area Code)", "Secondary District Coordinator's Phone Number (Prefix)", "Secondary District Coordinator's Phone Number (Suffix)", "Secondary District Coordinator's Fax Number (Area Code)", "Secondary District Coordinator's Fax Number (Prefix)", "Secondary District Coordinator's Fax Number (Suffix)", "Secondary District Coordinator's Cell Number (Area Code)", "Secondary District Coordinator's Cell Phone Number (Prefix)", "Secondary District Coordinator's Cell Number (Suffix)");


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








//function checkFMHIDistCoordForm(formobj)
//	{
//		if (checkFMHIRequired(formobj) == false)
//			{return false;}
//		else {			
//			if (checkFMHIIfNum(formobj) == false) {					
//				return false;
//			}
//			else {
//				if (checkFMHIEmail(formobj) == false)
//					{return false;}
//				else 
//					{return true;}
//			}		
//		}	
//	}
//	
	
	
function checkFMHIDistCoordForm(formobj) {
    if (checkFMHIRequired(formobj) == false)
    { return false; }
    else {
        if (checkFMHIIfNum(formobj) == false) {
            return false;
        }
        else {
                      if (checkFMHIEmail(formobj) == false) 
                        {return false;}
                      else
                        {return true;}
           
        }
    }
}

function checkFMHIEmail(formobj) {

    var str = document.forms[0].elements["ctl00_ContentPlaceHolder1_txtDistrictCoordEmail_2"].value;

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
