function validateForm() {
  
    var firstName = document.getElementById("firstname").value;
    var lastName = document.getElementById("lastname").value;
    var mobile = document.getElementById("mobile").value;
    var list = document.getElementsById("GenderList");
    var gender = list.getElementsByTagName("input");
    
    if (firstName == '' && lastName == '' && mobile == '') {
        alert("Enter all fields");
        return false;
    }
    if (firstName == '') {
        alert("FirstName can't be blank");
        firstName.focus();
        return false;
    }   
    if (lastName == '') {
        alert("LastName can't be blank");
        lastName.focus();
        return false;
    }
    if (mobile == '') {
        alert("Enter your mobile number");
        mobile.focus();
        return false;
    }
    if (!(gender[0].checked) && !(gender[0].checked)) {
        alert("Please select gender");
        return false;
    }
    var dotNet = document.getElementById("NetCheckBox").checked;
    var java = document.getElementById("JavaCheckBox").checked;
    var sdet = document.getElementById("SdetCheckBox.ClientID").checked;
   
    if (!(dotNet || java || sdet)) {
        document.getElementById("NetCheckBox.ClientID").focus();
        alert("Please select atleast one stream.");
        return false;
    }

  
    
}
