
function checkform(formobj)
	{
	    if (checkRequired(document.forms[0]) == false)
			{return false;}
		else{
		    if (checkIfNumerical(document.forms[0]) == false)
				{return false;}
			else {
			    if (checkRanges(document.forms[0]) == false)
					{return false;}
				else {					
					return true;
				}
			}		
		}	
	}
	
	
	
	function checkIfNumerical(formobj){
	
		// Enter name of all fields
	    var fieldValues = Array("ctl00_ContentPlaceHolder1_txtDemoTchAmericanIndian", "ctl00_ContentPlaceHolder1_txtDemoTchAsian", "ctl00_ContentPlaceHolder1_txtDemoTchBlack", "ctl00_ContentPlaceHolder1_txtDemoTchHispanic", "ctl00_ContentPlaceHolder1_txtDemoTchMulticultural", "ctl00_ContentPlaceHolder1_txtDemoTchWhite", "ctl00_ContentPlaceHolder1_txtDemoTchOther", "ctl00_ContentPlaceHolder1_txtDemoTchTotalEnrollment", "ctl00$ContentPlaceHolder1$txtDemoTchStudentsWithIEP", "ctl00_ContentPlaceHolder1_txtDemoTchPercFreeRedcLunch", "ctl00_ContentPlaceHolder1_txtDemoTchTotalInstStaff", "ctl00_ContentPlaceHolder1_txtDemoTchPercInstStaff", "ctl00_ContentPlaceHolder1_txtDemoTchPercAdvDegree", "ctl00_ContentPlaceHolder1_txtDemoTchPercOOFTeacher");
			// Enter field description to appear in the dialog box
			var fieldDescription = Array("American Indian Enrollment", "Asian Enrollment", "Black Enrollment", "Hispanic Enrollment", "Multiracial Enrollment", "White Enrollment", "Other Enrollment", "Total Enrollment", "Students with IEP", "Student Percentage on Free/Reduced Lunch", "Total Instructional Staff", "% of Staff that is Instructional", "% of Teachers with an Advanced Degree", "% of Out-of-Field Teachers");
			
			
			var alertMsg = "The following fields require numerical entries:\n\n";
			var l_Msg = alertMsg.length;		
			
			for (var i = 0; i < fieldValues.length; i++){
			    var obj = document.forms[0].elements[fieldValues[i]];
				if (obj){
					if (obj.value != "" && obj.value != null){					
						if(isNaN(obj.value)){					
							alertMsg += " - " + fieldDescription[i] + "\n";
						}
					}				
				}
			}
		
			if (alertMsg.length == l_Msg){			
				return true;
			}
			else{
				alert(alertMsg);			
				return false;
			}
	}

	function checkRequired(formobj)
	{		
		// Enter name of mandatory fields
	    var fieldRequired = Array("ctl00_ContentPlaceHolder1_txtDemoTchTotalEnrollment", "ctl00$ContentPlaceHolder1$DemoTchTargBehIntv", "ctl00$ContentPlaceHolder1$DemoTchIndLvlPbs");
		// Enter field description to appear in the dialog box
		var fieldDescription = Array("Total Enrollment", "Targeted Group Behavior Interventions(s)", "Individual Level PBS");
		// dialog message
		
		
		var alertMsg = "Please complete the following fields:\n\n";
		var l_Msg = alertMsg.length;		
		
		for (var i = 0; i < fieldRequired.length; i++){
		    var obj = document.forms[0].elements[fieldRequired[i]];
			if (obj){
				
				if (obj.type == undefined)
				{
					var blnchecked = false;
					for (var j = 0; j < obj.length; j++)
					{
						if (obj[j].checked)
						{
							blnchecked = true;
						}
					}
					if (!blnchecked){
						alertMsg += " - " + fieldDescription[i] + "\n";
					}
				}
				else
				{				
					if (obj.value == "" || obj.value == null){
						alertMsg += " - " + fieldDescription[i] + "\n";
					}
				}
			}
		}
	
		if (alertMsg.length == l_Msg){			
			return true;
		}
		else{
			alert(alertMsg);
			return false;
		}	
	}
	
	
	
	function checkRanges(formobj)
	{
	    var IEPMax = document.forms[0].elements["ctl00_ContentPlaceHolder1_txtDemoTchTotalEnrollment"].value;
		
		// Enter name of mandatory fields
	    var fieldValues = Array("ctl00_ContentPlaceHolder1_txtDemoTchStudentsWithIEP", "ctl00_ContentPlaceHolder1_txtDemoTchPercFreeRedcLunch", "ctl00_ContentPlaceHolder1_txtDemoTchPercInstStaff", "ctl00_ContentPlaceHolder1_txtDemoTchPercAdvDegree", "ctl00_ContentPlaceHolder1_txtDemoTchPercOOFTeacher");
		// Enter the range of the variable
		var fieldRange = Array("0-" + IEPMax, "0-100", "0-100", "0-100", "0-100");		
		// Enter field description to appear in the dialog box
		var fieldDescription = Array("Students with IEP", "Student Percentage on Free/Reduced Lunch", "% of Staff that is Instructional", "% of Teachers with an Advanced Degree", "% of Out-of-Field Teachers");
		
		var alertMsg = "Please enter a number within the proper range for:\n\n";
		var l_Msg = alertMsg.length;
		var passed = true;
		
		for (var i = 0; i < fieldValues.length; i++){
		    var obj = document.forms[0].elements[fieldValues[i]];
			if (obj){				
				if (obj.value != "")
				{
					passed = validateRange(obj.value, fieldRange[i]);					
					if (passed == false)
					{					 
						alertMsg += " - " + fieldDescription[i] + " (" + fieldRange[i] + ") \n";
					}
				}			
			}
		}
		if (alertMsg.length == l_Msg){			
			return true;
		}
		else{
			alert(alertMsg);			
			return false;
		}	
	}
	
	
	function validateRange(objValue, range)
	{
		var lowerBound, upperBound, number;
		lowerBound = parseInt(range.substring(0,range.indexOf('-')));
		upperBound = parseInt(range.substring(range.indexOf('-') + 1));
		number = parseInt(objValue);
				
		if ((objValue != "") && (isNaN(number) == false) && (number >= lowerBound) && (number <= upperBound))
			{return true;}
		else
			{return false;}
	}