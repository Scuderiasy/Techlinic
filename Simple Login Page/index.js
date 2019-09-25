function aa()
{
    if(document.getElementById("username").value == "aa" && document.getElementById("password").value == "123456")
    {
        document.getElementById("login").style.display = "none";
        document.getElementById("content").style.display = "block";
    }
    else
    {
        alert("Username or Password wrong")
    }
}