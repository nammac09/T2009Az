<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml"
      xmlns:th="http://www.thymeleaf.org">
<head>
    <meta charset="utf-8" />
    <title>Create New Product</title>
</head>
<body>
<div align="center">
    <h1>Create New Product</h1>
    <br />
    <form action="#" th:action="@{/save}" th:object="${employee}"
          method="post">

        <table border="0" cellpadding="10">
            <tr>
                <td>Product Name:</td>
                <td><input type="text" th:field="*{name}" /></td>
            </tr>
            <tr>
                <td>Brand:</td>
                <td><input type="text" th:field="*{wage}" /></td>
            </tr>
            <tr>
                <td colspan="2"><button type="submit">Save</button> </td>
            </tr>
        </table>
    </form>
</div>
</body>
</html>