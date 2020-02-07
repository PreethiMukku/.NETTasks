<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="RegistrationForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        td{
            padding: 10px;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style ="border:hidden">
            <tr>
                <td><label>First Name</label></td>
                <td><input type ="text" name="firstname" /></td>              
            </tr>
            <tr>
                <td><label>Last Name</label></td>
                <td><input type ="text" name="lasttname" /></td>               
            </tr>
            <tr>
                <td><label>Email</label></td>
                <td><input type="email" name="email" /></td>               
            </tr>
             <tr>
                <td><label>Mobile No</label></td>
                <td><input type="number" name="email" /></td>               
            </tr>
             <tr>
                <td><label>Gender</label></td>
                 <td><input type="radio" name="gender" value="male"/> Male<br/>
                    <input type="radio" name="gender" value="female"/> Female<br/>
                 </td>             
            </tr>
            <tr>
                <td><label>Stream</label></td>
                <td><input type="checkbox" name="stream" value="Java"/>JAVA<br/>
                    <input type="checkbox" name="stream" value="dotnet"/>Dot NET<br/>
                </td>               
            </tr>
            <tr>
                <td><label>Country</label><br/>
                    <label>State</label><br/>
                    <label>City</label><br/>
                </td>
                <td>
                    <asp:DropDownList ID="CountryList" runat="server" DataSourceID="CountryDataSource" DataTextField="Country_Name" DataValueField="Country_Id" AutoPostBack="True">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="CountryDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:UserDetailsConnectionString %>" SelectCommand="SELECT [Country_Name], [Country_Id] FROM [CountryList]"></asp:SqlDataSource>
                    <br/>
                    <asp:DropDownList ID="StateList" runat="server" DataSourceID="StateDataSource" DataTextField="State_Name" DataValueField="State_Id" AutoPostBack="True">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="StateDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:UserDetailsConnectionString %>" SelectCommand="SELECT [State_Name], [State_Id] FROM [State_List] WHERE ([FK_Country_Id] = @FK_Country_Id)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="CountryList" Name="FK_Country_Id" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <br/>
                    <asp:DropDownList ID="CityList" runat="server" DataSourceID="CityDataSource" DataTextField="City_Name" DataValueField="City_Name" AutoPostBack="True">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="CityDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:UserDetailsConnectionString %>" SelectCommand="SELECT [City_Name] FROM [City_List] WHERE ([FK_State_Id] = @FK_State_Id)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="StateList" Name="FK_State_Id" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>       
                </td>               
            </tr>
            <tr>
                <td>
                    <label><br/>Date of Birth<br/></label>
                </td>
                <td>
                    <asp:Calendar ID="Calendar1" runat="server" Height="20px" Width="20px"></asp:Calendar>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
