<%@ page language="java" contentType="text/html; charset=UTF-8"
         pageEncoding="UTF-8" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>

<head>
    <title>Management Application</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"
          integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>

<body>
<br>
<div class="container col-md-5">
    <div class="card">
        <div class="card-body">
            <c:if test="${employee != null}">
            <form action="update" method="post">
                </c:if>
                <c:if test="${employee == null}">
                <form action="insert" method="post">
                    </c:if>

                    <caption>
                        <h2>
                            <c:if test="${employee != null}">
                                Edit User
                            </c:if>
                            <c:if test="${employee == null}">
                                Add New Employee
                            </c:if>
                        </h2>
                    </caption>

                    <c:if test="${employee != null}">
                        <input type="hidden" name="id" value="<c:out value='${employee.id}' />"/>
                    </c:if>

                    <fieldset class="form-group">
                        <label>Name</label> <input type="text" value="<c:out value='${employee.name}' />"
                                                   class="form-control" name="name" required="required">
                    </fieldset>

                    <fieldset class="form-group">
                        <label>Email</label> <input type="text" value="<c:out value='${employee.email}' />"
                                                    class="form-control" name="email">
                    </fieldset>

                    <fieldset class="form-group">
                        <label>Address</label> <input type="text" value="<c:out value='${employee.address}' />"
                                                      class="form-control" name="address">
                    </fieldset>

                    <fieldset class="form-group">
                        <label>Phone</label> <input type="text" value="<c:out value='${employee.phone}' />"
                                                    class="form-control" name="phone">
                    </fieldset>

                    <button type="submit" class="btn btn-success">Save</button>
                    <a href="list">
                        <button type="button" class="btn btn-primary">Back To List</button>
                    </a>
                </form>
        </div>
    </div>
</div>
</body>

</html>