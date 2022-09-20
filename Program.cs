using System.Text;

string firstName = " Harry ";
string lastName = " Potter";
string message = "His name is";

// new string created, message not modified
message += firstName + lastName + " and he is a wizard"; 

// use string builder, faster, no additiona memory created, can return ToString()
StringBuilder sb = new StringBuilder();
sb.Append("His name is");
sb.Append(" Harry ");
sb.Append(" Potter");
sb.Append(" and he is a wizard");
sb.ToString();