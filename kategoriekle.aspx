﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kategoriekle.aspx.cs" Inherits="EntityBlog.kategoriekle" %>


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

    <link rel="stylesheet" href="/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css" />
    <!-- Theme style -->
    <link rel="stylesheet" href="/dist/css/AdminLTE.min.css" />
    <!-- AdminLTE Skins. Choose a skin from the css/skins
       folder instead of downloading all of them to reduce the load. -->
    <link rel="stylesheet" href="/dist/css/skins/_all-skins.min.css" />

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
                    <h1>Kategoriler
       
                        <small>Yönetim Paneli</small>
                    </h1>
                    <ol class="breadcrumb">
                        <li><a href="#"><i class="fa fa-dashboard"></i>kategori Ekle</a></li>
                        <!--  <li class="active">Dashboard</li>-->
                    </ol>
                </section>

                <!-- Main content -->
                <section class="content">
                    <!-- Small boxes (Stat box) -->
                    <div class="row">
                        <div class="col-md-12">


                            <div class="box">
                                <div class="box-header with-border">
                                    <h3 class="box-title">Kategori Ekle</h3>
                                </div>
                                <!-- /.box-header -->
                                <!-- form start -->
                                <div class="form-horizontal">
                                    <div class="box-body">
                                        <div class="form-group">
                                            <label for="inputEmail3" class="col-sm-2 control-label">Kategori Adı</label>

                                            <div class="col-sm-10" style="margin-bottom: 20px">
                                                <asp:TextBox ID="txtKategoriAdi" runat="server" type="text" class="form-control" placeholder="kategori adı"></asp:TextBox>
                                            </div>
                                            <label for="inputEmail3" class="col-sm-2 control-label">Kategori Açıklama</label>
                                            <div class="col-sm-10">
                                                <asp:TextBox ID="txtArea" runat="server" type="text" TextMode="MultiLine" class="form-control" placeholder="kategori açılklaması"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- /.box-body -->
                                    <div class="box-footer">
                                        <asp:Button ID="Button1" type="submit" class="btn btn-info" runat="server" Text="Kaydet" OnClick="Button1_Click"    />
                                    </div>
                                    <!-- /.box-footer -->
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
                <!-- /.content -->
            </div>

            <!-- /.content-wrapper -->
            <uc1:public_footer runat="server" ID="public_footer" />
            <script src="/bower_components/datatables.net/js/jquery.dataTables.min.js"></script>
            <script src="/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"></script>
            <!-- SlimScroll -->
            <script src="bower_components/jquery-slimscroll/jquery.slimscroll.min.js"></script>
            <!-- FastClick -->
            <script src="/bower_components/fastclick/lib/fastclick.js"></script>
            <!-- AdminLTE App -->
            <!-- page script -->
            <script>
                $(function () {
                    $('#example1').DataTable()
                    $('#example2').DataTable({
                        'paging': true,
                        'lengthChange': false,
                        'searching': false,
                        'ordering': true,
                        'info': false,
                        'autoWidth': false
                    })
                })
            </script>
        </div>
    </form>
</body>
</html>

