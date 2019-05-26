<%@ Page Title="Sobre Nosotros" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="AMARON_INTERFACE.AboutUs" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style>
        .about-us{
            display: block;
            width: 100%;
            line-height: 1.6em;
        }
        .about-us h2 {
            margin-bottom: 50px;
            padding-bottom: 40px;
            border-bottom: 1px solid #CCCCCC;
            margin-top: 50px;
            padding-top: 40px;
            border-top: 1px solid #CCCCCC;
            font-size: 70px;
            text-align: center;
            text-transform: uppercase;
            display: block;
        }
        .about-us h4{
            text-align: center;
            display: block;
            font-size: 30px;
        }
        .about-us about-intro{
            margin-bottom: 50px;
        }
        .about-us about-intro p{
            margin: 20px 0 0 0;
            padding: 0;
        }
        .about-us about-intro p:first-child{
            margin-top:0;
        }
        .about-us img {
            margin: 10px auto;
            display: block;
            width: 50%;
        }
        .about-us iframe{
            width: 70%;
            height: 250px;
            margin: 10px auto;
            display: block;
        }
        .about-us a{
            margin: 10px auto;
            display: block;
            width: 30%;
            height: auto;
            text-align: center;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper row2">
        <div id="container" class="clear">
            <div class="about-us">
                <section class="about-intro">
                    <h2>Sobre Nosotros</h2>
                    <img class="img-responsive img-portfolio img-hover" src="Imagenes/aboutUs-Alcohol.png" alt="">
                    <div style="width: 60%; margin-left: 20%; text-align: center; font-size: 22px; font-family: Georgia" >
                        <p>Es un pensamiento común en edades tempranas querer crecer rápido. Ser adultos, tener dinero y hacer lo
                            que quieras cuando quieras. Hasta que realmente somos adultos, comienzan a pesar las responsabilidades, el
                            día a día es agotador, te faltan horas en el reloj... Ansías que llegue el fin de semana, y qué mejor para
                            desconectar que preparar el plato que más te gusta, o pedir comida, invitar a tus amigos, a tus padres, o a esa
                            persona especial y acabar la velada con una buena copa. Si te gusta lo que oyes, te gustará <strong>AmaRon</strong>. </p>
                    </div>
                    </section>
                <section class="about-map">
                    <h2>Dónde Estamos</h2>
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3127.3630437906095!2d-0.5138438849322668!3d38.38685407965262!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd6236b980f079a5%3A0xf3dd7912db768f0a!2sEscuela+Polit%C3%A9cnica+Superior+I%2C+03690+San+Vicente+del+Raspeig%2C+Alicante!5e0!3m2!1ses!2ses!4v1556319457188!5m2!1ses!2ses"></iframe>
                </section>
                <section class="about-contact">
                    <h2>Contacta</h2>
                    <h4>¿Tienes alguna duda? Contacta con nosotros aquí.</h4>
                    <a href="Contact.aspx" class="btn btn-success" role="button"> Contáctanos</a>
                </section>
            </div>
        </div>
    </div>
</asp:Content>
