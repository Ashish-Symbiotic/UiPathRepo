function(e,data)
{
    var z = JSON.parse(data);
    var firstName = z.firstName;
    var lastName = z.lastName;
    var phone = z.phone;
    var email = z.email;
    var role = z.role;
    var address = z.address;
    var company = z.company;
    console.table(data);

    var label_bylabel = document.getElementsByTagName("label");
    for (let i=0; i<label_bylabel.length;i++)
    {
        var lable_text = label_bylabel[i].innerText;
        //console.log(lable_text);
        let input_id = label_bylabel[i].nextSibling.id;
            if(lable_text == "Company Name"){
                //console.log("Compnay Name");
                document.getElementById(input_id).value = company;
            }
            else if(lable_text == "First Name")
            {
                document.getElementById(input_id).value = firstName;
            }
            else if(lable_text == "Last Name")
            {
                document.getElementById(input_id).value = lastName;
            }
            else if(lable_text == "Role in Company")
            {
                document.getElementById(input_id).value = role;
            }
            else if(lable_text == "Address")
            {
                document.getElementById(input_id).value = address;
            }
            else if(lable_text == "Email")
            {
                document.getElementById(input_id).value = email;
            }
            else if(lable_text == "Phone Number")
            {
                document.getElementById(input_id).value = phone;
            }
        //let element_ = document.getElementById(input_id);
        //element_.style.backgroundColor = "#FDFF47";

        //element_.value="Copany NBame";
       // await waitforme(1000);
        
    
    }
    var c = document.getElementsByClassName("btn uiColorButton");
    c[0].click();
}