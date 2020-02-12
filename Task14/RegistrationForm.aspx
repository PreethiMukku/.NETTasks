<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="RegistrationForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        td{
            padding: 10px;
        }
        </style>
    <script src="Validator.js" type="text/javascript"></script>

  <!---  <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.microsoft.com/ajax/jquery.validate/1.5.5/jquery.validate.min.js"></script>--->
   
</head>
<body style="height: 654px; width: 1493px">
    
    <form id="form" runat="server">     
        <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="fname" runat="server" Text="First Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="firstname" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="firstnameErrorMsg" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lname" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="lastname" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lastnameErrorMsg" runat="server"></asp:Label>
                    
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="EmailId" runat="server" Text="Email id"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="mail" runat="server" TextMode="Email"></asp:TextBox>
                     
                </td>
                <td>
                    <asp:Label ID="emailErrorMsg" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="MobileNo" runat="server" Text="Mobile No"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="mobile" runat="server" MaxLength="10" TextMode="Number"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="mobileNoErrorMsg" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Gender" runat="server" Text="Gender"></asp:Label>
                </td>
                <td>                
                    <asp:RadioButtonList ID="genderList" runat="server">
                        <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Female" Value="2"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    <asp:Label ID="genderErrorMsg" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Stream" runat="server" Text="Stream"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="NetCheckBox" runat="server" Text=". Net" /><br/>
                    <asp:CheckBox ID="JavaCheckBox" runat="server" Text="JAVA"/><br/>
                    <asp:CheckBox ID="SdetCheckBox" runat="server" Text="SDET"/>
                </td>
                <td>
                    <asp:Label ID="streamErrorMsg" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Address" runat="server" Text="Address"></asp:Label>
                </td>
                <td>
                    
                    <asp:DropDownList ID="CountryList" runat="server" DataSourceID="CountryDataSource" DataTextField="Country_Name" DataValueField="Country_Id" AutoPostBack="True">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="CountryDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:UserDetailsConnectionString2 %>" SelectCommand="SELECT [Country_Name], [Country_Id] FROM [CountryList]" ProviderName="System.Data.SqlClient">
                    </asp:SqlDataSource>                    
                    <br/>
                   
                    <asp:DropDownList ID="StateList" runat="server" AutoPostBack="True" DataSourceID="StateDataSource" DataTextField="State_Name" DataValueField="State_Id">                     
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="StateDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:UserDetailsConnectionString2 %>" SelectCommand="SELECT [State_Name], [State_Id] FROM [State_List] WHERE ([FK_Country_Id] = @FK_Country_Id)" ProviderName="System.Data.SqlClient">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="CountryList" Name="FK_Country_Id" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>        
                    <br/>

                    <asp:DropDownList ID="CityList" runat="server" DataSourceID="CityDataSource" DataTextField="City_Name" DataValueField="City_Name" AutoPostBack="True">                      
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="CityDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:UserDetailsConnectionString2 %>" SelectCommand="SELECT [City_Name] FROM [City_List] WHERE ([FK_State_Id] = @FK_State_Id)" ProviderName="System.Data.SqlClient">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="StateList" Name="FK_State_Id" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
  
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="DOB" runat="server" Text="Date of Birth"></asp:Label>
                </td>
                <td>
                    <asp:Calendar ID="calendar" runat="server"></asp:Calendar>
                </td>
                <td>
                    <asp:Label ID="calenderErrorMsg" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button" runat="server" OnClick="formValidation" OnClientClick="return validateForm()" Text="Submit" />
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="JqueryValidation" CssClass="bg-success" />
                </td>
            </tr>
        </table>  
        </div>
    </form>    
</body>
    
      <script>
        $(document).ready(function () {
        $.validator.addMethod("match", function (value, element) {
            return this.optional(element) || /^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+\.[a-zA-Z.]{2,5}$/i.test(value);
        }, "Please enter a valid email address.");
        $("#<%=form.ClientID%>").validate({
            rules: {
                firstname: {
                    required: true
                },
                lastname: {
                    required: true
                },
                mail: {
                    required: true,
                    match: true,
                },
                mobile: {
                    required: true
                },
                genderList: {
                    required: true,
                },
                calendar: {
                    required: true,
                }
            },
            messages: {
                firstname: {
                    required: "First Name can't be blank."
                },
                lastName: {
                    required: "Last Name can't be blank."
                },
                mail: {
                    required: "Enter your Mail Id.",
                    match: "Enter a valid E-mail ID.",
                },
                mobile: {
                    required: "Mobile number is required."
                },
                GenderList: {
                    required: "Select Gender"
                },
                Calendar: {
                    required: "Select your Date Of Birth"
                },
            },
        });
    });
    </script>
</html>



