function submitonce(theform) {
    if (document.all || document.getElementById) {
        //screen thru every element in the form, and hunt down "submit" and "reset"
        for (i = 0; i < theform.length; i++) {
            var tempobj = theform.elements[i]
            if (tempobj.type.toLowerCase() == "btnsubmit" || tempobj.type.toLowerCase() == "reset")
            //disable em
                tempobj.disabled = true
        }
    }
}

function radio_button_checker_datahistory() {
    // set var radio_choice to false
    var radio_choice = false;
    var radioRequired = "ctl00$ContentPlaceHolder1$radiodatahistory"
 //   alert(document.forms[0].ctl00$ContentPlaceHolder1$radiodatahistory.length);
    if (document.forms[0].ctl00$ContentPlaceHolder1$radiodatahistory && document.forms[0].ctl00$ContentPlaceHolder1$radiodatahistory.length) {

        // Loop from zero to the one minus the number of radio button selections
        for (counter = 0; counter < document.forms[0].ctl00$ContentPlaceHolder1$radiodatahistory.length; counter++) {
            // If a radio button has been selected it will return true
            // (If not it will return false)
            if (document.forms[0].ctl00$ContentPlaceHolder1$radiodatahistory[counter].checked)
                radio_choice = true;
        }

    } else if (document.forms[0].ctl00$ContentPlaceHolder1$radiodatahistory) {
    if (document.forms[0].ctl00$ContentPlaceHolder1$radiodatahistory.checked)
            radio_choice = true;
    }

    if (!radio_choice) {
        // If there were no selections made display an alert box
        alert("Please make a selection to proceed.")
        return false;
    }
    return (true);
    //document.forms[0].submit();
}


function radio_button_checker_dis_midyr_rep() {
    // set var radio_choice to false
    var radio_choice = false;
    var radioRequired = "ctl00$ContentPlaceHolder1$grpMidYDistRep"
    //   alert(document.forms[0].ctl00$ContentPlaceHolder1$radiodatahistory.length);
    if (document.forms[0].ctl00$ContentPlaceHolder1$grpMidYDistRep && document.forms[0].ctl00$ContentPlaceHolder1$grpMidYDistRep.length) {

        // Loop from zero to the one minus the number of radio button selections
        for (counter = 0; counter < document.forms[0].ctl00$ContentPlaceHolder1$grpMidYDistRep.length; counter++) {
            // If a radio button has been selected it will return true
            // (If not it will return false)
            if (document.forms[0].ctl00$ContentPlaceHolder1$grpMidYDistRep[counter].checked)
                radio_choice = true;
        }

    } else if (document.forms[0].ctl00$ContentPlaceHolder1$grpMidYDistRep) {
    if (document.forms[0].ctl00$ContentPlaceHolder1$grpMidYDistRep.checked)
            radio_choice = true;
    }

    if (!radio_choice) {
        // If there were no selections made display an alert box
        alert("Please make a selection to proceed.")
        return false;
    }
    return (true);
    //document.forms[0].submit();
}



/* PIC Form validation start */

function checkformPIC(formobj) {
    // alert('dfdfdf');
    // Enter name of mandatory fields
    var fieldRequired = Array("ctl00_ContentPlaceHolder1_ddlcoach", "ctl00$ContentPlaceHolder1$grpPicQuestion1", "ctl00$ContentPlaceHolder1$grpPicQuestion2", "ctl00$ContentPlaceHolder1$grpPicQuestion3", "ctl00$ContentPlaceHolder1$grpPicQuestion4", "ctl00$ContentPlaceHolder1$grpPicQuestion5", "ctl00$ContentPlaceHolder1$grpPicQuestion6", "ctl00$ContentPlaceHolder1$grpPicQuestion7", "ctl00$ContentPlaceHolder1$grpPicQuestion8", "ctl00$ContentPlaceHolder1$grpPicQuestion9", "ctl00$ContentPlaceHolder1$grpPicQuestion10", "ctl00$ContentPlaceHolder1$grpPicQuestion11", "ctl00$ContentPlaceHolder1$grpPicQuestion12", "ctl00$ContentPlaceHolder1$grpPicQuestion13", "ctl00$ContentPlaceHolder1$grpPicQuestion14", "ctl00$ContentPlaceHolder1$grpPicQuestion15", "ctl00$ContentPlaceHolder1$grpPicQuestion16", "ctl00$ContentPlaceHolder1$grpPicQuestion17", "ctl00$ContentPlaceHolder1$grpPicQuestion18", "ctl00$ContentPlaceHolder1$grpPicQuestion19", "ctl00$ContentPlaceHolder1$grpPicQuestion20", "ctl00$ContentPlaceHolder1$grpPicQuestion21", "ctl00$ContentPlaceHolder1$grpPicQuestion22", "ctl00$ContentPlaceHolder1$grpPicQuestion23", "ctl00$ContentPlaceHolder1$grpPicQuestion24", "ctl00$ContentPlaceHolder1$grpPicQuestion25", "ctl00$ContentPlaceHolder1$grpPicQuestion26", "ctl00$ContentPlaceHolder1$grpPicQuestion27", "ctl00$ContentPlaceHolder1$grpPicQuestion28", "ctl00$ContentPlaceHolder1$grpPicQuestion29", "ctl00$ContentPlaceHolder1$grpPicQuestion30", "ctl00$ContentPlaceHolder1$grpPicQuestion31", "ctl00$ContentPlaceHolder1$grpPicQuestion32", "ctl00$ContentPlaceHolder1$grpPicQuestion33", "ctl00$ContentPlaceHolder1$grpPicQuestion34", "ctl00$ContentPlaceHolder1$grpPicQuestion35", "ctl00$ContentPlaceHolder1$grpPicQuestion36", "ctl00$ContentPlaceHolder1$grpPicQuestion37", "ctl00$ContentPlaceHolder1$grpPicQuestion38", "ctl00$ContentPlaceHolder1$grpPicQuestion39", "ctl00$ContentPlaceHolder1$grpPicQuestion40", "ctl00$ContentPlaceHolder1$grpPicQuestion41", "ctl00$ContentPlaceHolder1$grpPicQuestion42", "ctl00$ContentPlaceHolder1$grpPicQuestion43", "ctl00$ContentPlaceHolder1$grpPicQuestion44");

    // Enter field description to appear in the dialog box
    var fieldDescription = Array("Identify a Coach", "Question 1", "Question 2", "Question 3", "Question 4", "Question 5", "Question 6", "Question 7", "Question 8", "Question 9", "Question 10", "Question 11", "Question 12", "Question 13", "Question 14", "Question 15", "Question 16", "Question 17", "Question 18", "Question 19", "Question 20", "Question 21", "Question 22", "Question 23", "Question 24", "Question 25", "Question 26", "Question 27", "Question 28", "Question 29", "Question 30", "Question 31", "Question 32", "Question 33", "Question 34", "Question 35", "Question 36", "Question 37", "Question 38", "Question 39", "Question 40", "Question 41", "Question 42", "Question 43", "Question 44");

    var alertMsg = "Please complete the following fields:\n\n";

    var l_Msg = alertMsg.length;

    for (var i = 0; i < fieldRequired.length; i++) {
        //alert(document.forms[0].elements[fieldRequired[i]]);
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
        submitonce(document.forms[0]);
        return true;
    }
    else {
        alert(alertMsg);
        return false;
    }
}



/* PIC Form validation end */

/* BOQ Form validation start */






function checkformBOQ(formobj) {
     //alert('dfdfdf');
    // Enter name of mandatory fields
    var fieldRequired = Array("ctl00_ContentPlaceHolder1_ddlcoach", "ctl00$ContentPlaceHolder1$grpBoqScoreMethod", "ctl00$ContentPlaceHolder1$BoqQuestion1", "ctl00$ContentPlaceHolder1$BoqQuestion2", "ctl00$ContentPlaceHolder1$BoqQuestion3", "ctl00$ContentPlaceHolder1$BoqQuestion4", "ctl00$ContentPlaceHolder1$BoqQuestion5", "ctl00$ContentPlaceHolder1$BoqQuestion6", "ctl00$ContentPlaceHolder1$BoqQuestion7", "ctl00$ContentPlaceHolder1$BoqQuestion8", "ctl00$ContentPlaceHolder1$BoqQuestion9", "ctl00$ContentPlaceHolder1$BoqQuestion10", "ctl00$ContentPlaceHolder1$BoqQuestion11", "ctl00$ContentPlaceHolder1$BoqQuestion12", "ctl00$ContentPlaceHolder1$BoqQuestion13", "ctl00$ContentPlaceHolder1$BoqQuestion14", "ctl00$ContentPlaceHolder1$BoqQuestion15", "ctl00$ContentPlaceHolder1$BoqQuestion16", "ctl00$ContentPlaceHolder1$BoqQuestion17", "ctl00$ContentPlaceHolder1$BoqQuestion18", "ctl00$ContentPlaceHolder1$BoqQuestion19", "ctl00$ContentPlaceHolder1$BoqQuestion20", "ctl00$ContentPlaceHolder1$BoqQuestion21", "ctl00$ContentPlaceHolder1$BoqQuestion22", "ctl00$ContentPlaceHolder1$BoqQuestion23", "ctl00$ContentPlaceHolder1$BoqQuestion24", "Bctl00$ContentPlaceHolder1$oqQuestion25", "ctl00$ContentPlaceHolder1$BoqQuestion26", "ctl00$ContentPlaceHolder1$BoqQuestion27", "ctl00$ContentPlaceHolder1$BoqQuestion28", "ctl00$ContentPlaceHolder1$BoqQuestion29", "ctl00$ContentPlaceHolder1$BoqQuestion30", "ctl00$ContentPlaceHolder1$BoqQuestion31", "ctl00$ContentPlaceHolder1$BoqQuestion32", "ctl00$ContentPlaceHolder1$BoqQuestion33", "ctl00$ContentPlaceHolder1$BoqQuestion34", "ctl00$ContentPlaceHolder1$BoqQuestion35", "ctl00$ContentPlaceHolder1$BoqQuestion36", "ctl00$ContentPlaceHolder1$BoqQuestion37", "ctl00$ContentPlaceHolder1$BoqQuestion38", "ctl00$ContentPlaceHolder1$BoqQuestion39", "ctl00$ContentPlaceHolder1$BoqQuestion40", "ctl00$ContentPlaceHolder1$BoqQuestion41", "ctl00$ContentPlaceHolder1$BoqQuestion42", "ctl00$ContentPlaceHolder1$BoqQuestion43", "ctl00$ContentPlaceHolder1$BoqQuestion44", "ctl00$ContentPlaceHolder1$BoqQuestion45", "ctl00$ContentPlaceHolder1$BoqQuestion46", "ctl00$ContentPlaceHolder1$BoqQuestion47", "ctl00$ContentPlaceHolder1$BoqQuestion48", "ctl00$ContentPlaceHolder1$BoqQuestion49", "ctl00$ContentPlaceHolder1$BoqQuestion50", "ctl00$ContentPlaceHolder1$BoqQuestion51", "ctl00$ContentPlaceHolder1$BoqQuestion52", "ctl00$ContentPlaceHolder1$BoqQuestion53", "ctl00$ContentPlaceHolder1$BoqQuestion54", "ctl00$ContentPlaceHolder1$BoqQuestion55", "ctl00$ContentPlaceHolder1$BoqQuestion56", "ctl00$ContentPlaceHolder1$BoqQuestion57", "ctl00$ContentPlaceHolder1$BoqQuestion58", "ctl00$ContentPlaceHolder1$BoqQuestion59", "ctl00$ContentPlaceHolder1$BoqQuestion60");
  
    // Enter field description to appear in the dialog box
  var fieldDescription = Array("Select Coach", "Score Method", "Question 1", "Question 2", "Question 3", "Question 4", "Question 5", "Question 6", "Question 7", "Question 8", "Question 9", "Question 10", "Question 11", "Question 12", "Question 13", "Question 14", "Question 15", "Question 16", "Question 17", "Question 18", "Question 19", "Question 20", "Question 21", "Question 22", "Question 23", "Question 24", "Question 25", "Question 26", "Question 27", "Question 28", "Question 29", "Question 30", "Question 31", "Question 32", "Question 33", "Question 34", "Question 35", "Question 36", "Question 37", "Question 38", "Question 39", "Question 40", "Question 41", "Question 42", "Question 43", "Question 44", "Question 45", "Question 46", "Question 47", "Question 48", "Question 49", "Question 50", "Question 51", "Question 52", "Question 53", "Question 54", "Question 55", "Question 56", "Question 57", "Question 58", "Question 59", "Question 60");
   
    var alertMsg = "Please complete the following fields:\n\n";

    var l_Msg = alertMsg.length;
   
    for (var i = 0; i < fieldRequired.length; i++) {
        //alert(document.forms[0].elements[fieldRequired[i]]);
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
        submitonce(document.forms[0]);
        return true;
    }
    else {
        alert(alertMsg);
        return false;
    }
}



function checkBATForm(formobj) {
    if (checkBATRequired(formobj) == false)
    { return false; }
    if (checkBATIfNotNum(formobj) == false) {
            return false;
        }


    }



    function checkBATRequired(formobj) {
        // Enter name of mandatory fields
        //var fieldRequired = Array("ctl00_ContentPlaceHolder1_ddlSchoolDistrict", "ctl00_ContentPlaceHolder1_txtDistrictName", "ctl00_ContentPlaceHolder1_txtCoachFirstName", "ctl00_ContentPlaceHolder1_txtCoachLastName", "ctl00_ContentPlaceHolder1_txtStreetAddress1", "ctl00_ContentPlaceHolder1_txtDistrictCity", "ctl00_ContentPlaceHolder1_txtDistrictState", "ctl00_ContentPlaceHolder1_txtDistrictZip", "ctl00_ContentPlaceHolder1_txtDistrictPhone01", "ctl00_ContentPlaceHolder1_txtDistrictPhone02", "ctl00_ContentPlaceHolder1_txtDistrictPhone03", "ctl00_ContentPlaceHolder1_txtDistrictFax01", "ctl00_ContentPlaceHolder1_txtDistrictFax02", "ctl00_ContentPlaceHolder1_txtDistrictFax03", "ctl00_ContentPlaceHolder1_txtDistrictCell01", "ctl00_ContentPlaceHolder1_txtDistrictCell02", "ctl00_ContentPlaceHolder1_txtDistrictCell03", "ctl00_ContentPlaceHolder1_txtDistrictCoachEmail");

        // Enter field description to appear in the dialog box
        // var fieldDescription = Array("Select District", "District Name",  "District Coach's First Name", "District Coach's Last Name", "District Street Address", "District City", "District State", "District Zip Code", "District Phone Number (Area Code)", "District Phone Number (Prefix)", "District Phone Number (Suffix)", "District Fax Number (Area Code)", "District Fax Number (Prefix)", "District Fax Number (Suffix)", "District Cell Number (Area Code)", "District Cell Number (Prefix)", "District Cell Number (Suffix)", "District Coach's Email");
        // dialog message
        var fieldRequired = Array("ctl00_ContentPlaceHolder1_ddlcoach","ctl00_ContentPlaceHolder1_txtTLeader","ctl00_ContentPlaceHolder1_txtTMembers")
        var fieldDescription = Array("Select Coach","Enter Team Leaders/Coordinators","Enter Team Members")
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
 
function checkBATIfNotNum(formobj) {
    // Enter name of all fields
    var fieldValues = Array("ctl00_ContentPlaceHolder1_txtTLeader", "ctl00_ContentPlaceHolder1_txtTMembers");
    // Enter field description to appear in the dialog box
    var fieldDescription = Array( "Team Leader/Coordinator", "Team Members" );


    var alertMsg = "Enter valid data for the following entries:\n\n";
    var l_Msg = alertMsg.length;

    for (var i = 0; i < fieldValues.length; i++) {
        var obj = document.forms[0].elements[fieldValues[i]];
        if (obj) {
            if (obj.value != "" && obj.value != null) {
                if (!isNaN(obj.value)) {
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
/* BOQ Form validation end */


function radio_button_checker_schReports() {
    // set var radio_choice to false
    var radio_choice = false;
    var radioRequired = "ctl00$ContentPlaceHolder1$selectrpt"
    //   alert(document.forms[0].ctl00$ContentPlaceHolder1$radiodatahistory.length);
    if (document.forms[0].ctl00$ContentPlaceHolder1$selectrpt && document.forms[0].ctl00$ContentPlaceHolder1$selectrpt.length) {

        // Loop from zero to the one minus the number of radio button selections
        for (counter = 0; counter < document.forms[0].ctl00$ContentPlaceHolder1$selectrpt.length; counter++) {
            // If a radio button has been selected it will return true
            // (If not it will return false)
            if (document.forms[0].ctl00$ContentPlaceHolder1$selectrpt[counter].checked)
                radio_choice = true;
        }

    } else if (document.forms[0].ctl00$ContentPlaceHolder1$selectrpt) {
    if (document.forms[0].ctl00$ContentPlaceHolder1$selectrpt.checked)
            radio_choice = true;
    }

    if (!radio_choice) {
        // If there were no selections made display an alert box
        alert("Please make a selection to proceed.")
        return false;
    }
    return (true);
    //document.forms[0].submit();
}


function radio_button_checker_endyrdistDLR() {
    // set var radio_choice to false
    var radio_choice = false;
    var radioRequired = "ctl00$ContentPlaceHolder1$selectrpt"
    //   alert(document.forms[0].ctl00$ContentPlaceHolder1$radiodatahistory.length);
    if (document.forms[0].ctl00$ContentPlaceHolder1$selectrpt && document.forms[0].ctl00$ContentPlaceHolder1$selectrpt.length) {

        // Loop from zero to the one minus the number of radio button selections
        for (counter = 0; counter < document.forms[0].ctl00$ContentPlaceHolder1$selectrpt.length; counter++) {
            // If a radio button has been selected it will return true
            // (If not it will return false)
            if (document.forms[0].ctl00$ContentPlaceHolder1$selectrpt[counter].checked)
                radio_choice = true;
        }

    } else if (document.forms[0].ctl00$ContentPlaceHolder1$selectrpt) {
    if (document.forms[0].ctl00$ContentPlaceHolder1$selectrpt.checked)
            radio_choice = true;
    }

    if (!radio_choice) {
        // If there were no selections made display an alert box
        alert("Please make a selection to proceed.")
        return false;
    }
    return (true);
    //document.forms[0].submit();
}
