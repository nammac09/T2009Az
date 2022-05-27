<%@ page language="java" contentType="text/html; charset=UTF-8"
         pageEncoding="UTF-8" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>

<head>
    <title>Employee Management Application</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"
          integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>

<body>
<br>

<div class="row">
    <!-- <div class="alert alert-success" *ngIf='message'>{{message}}</div> -->

    <div class="container">
        <h3 class="text-center">List of Employee</h3>
        <hr>
        <div class="container text-center">

            <a href="<%=request.getContextPath()%>/new" class="btn btn-success">Add New Employee</a>
            <a href="<%=request.getContextPath()%>/" class="btn btn-primary">Back To Home</a>
        </div>
        <br>
        <table class="table table-bordered">
            <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Email</th>
                <th>Address</th>
                <th>Phone</th>
                <th>Actions</th>
            </tr>
            </thead>
            <tbody>
            <c:forEach var="employee" items="${listEmployee}">

                <tr>
                    <td>
                        <c:out value="${employee.id}"/>
                    </td>
                    <td>
                        <c:out value="${employee.name}"/>
                    </td>
                    <td>
                        <c:out value="${employee.email}"/>
                    </td>
                    <td>
                        <c:out value="${employee.address}"/>
                    </td>
                    <td>
                        <c:out value="${employee.phone}"/>
                    </td>
                    <td>
                        <a href="edit?id=<c:out value='${employee.id}' />">Edit</a>
                        <a href="delete?id=<c:out value='${employee.id}' />">Delete</a>
                    </td>
                </tr>
            </c:forEach>
            </tbody>
        </table>
    </div>
</div>

<script>

</script>
</body>


</html>