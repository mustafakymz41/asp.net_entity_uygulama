<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EntityBlog.WebForm1" %>

<%@ Register Src="~/public_meta.ascx" TagPrefix="uc1" TagName="public_meta" %>
<%@ Register Src="~/public_header.ascx" TagPrefix="uc1" TagName="public_header" %>
<%@ Register Src="~/public_footer.ascx" TagPrefix="uc1" TagName="public_footer" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>Blog Sitesi</title>
    <uc1:public_meta runat="server" ID="public_meta" />

</head>
<body class="hold-transition skin-blue sidebar-mini">
    <form id="form1" runat="server">
        <div class="wrapper">
            <uc1:public_header runat="server" ID="public_header" />
            <!-- Left side column. contains the logo and sidebar -->

            <!-- Content Wrapper. Contains page content -->
            <div class="content-wrapper">
                <!-- Content Header (Page header) -->
                <section class="content-header">
                    <h1>Ana Sayfa
       
                        <small>Yönetim Paneli</small>
                    </h1>
                    <ol class="breadcrumb">
                        <li><a href="#"><i class="fa fa-dashboard"></i>Ana Sayfa</a></li>
                        <!--  <li class="active">Dashboard</li>-->
                    </ol>
                </section>

                <!-- Main content -->
                <section class="content">
                    <!-- Small boxes (Stat box) -->
                    <div class="row">
                        <div class="col-md-12">
                            Yan tarafta bulunan seçenekler ile işlemler yapabilirsiniz...
       
                        </div>
                    </div>
                </section>
                <!-- /.content -->
            </div>

            <!-- /.content-wrapper -->
            <uc1:public_footer runat="server" ID="public_footer" />
        </div>
    </form>

</body>
</html>
