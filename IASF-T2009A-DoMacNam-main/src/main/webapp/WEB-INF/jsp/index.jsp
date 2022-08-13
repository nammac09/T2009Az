<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>

<head>
    <title>Title</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</head>
<body>
<div align="center">
    <h1>Employee List</h1>
    <a href="/new">Create New Employee</a>
    <br/><br/>
    <table border="1" cellpadding="10">
        <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Wage</th>
        </tr>
        </thead>
        <tbody>
        <c:forEach items="${listEmployees}" var="employee">
            <td>${employee.id}</td>
            <td>${employee.name}</td>
            <td>${employee.wage}</td>
        </c:forEach>
        </tbody>
    </table>
</div>
</body>
</html>