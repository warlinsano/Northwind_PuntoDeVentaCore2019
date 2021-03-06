#pragma checksum "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019-master\Northwind_PuntoDeVentaCore2019\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17d19ae063b58052dba072b62e61701291f04fc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019-master\Northwind_PuntoDeVentaCore2019\Views\_ViewImports.cshtml"
using Northwind_PuntoDeVentaCore2019;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019-master\Northwind_PuntoDeVentaCore2019\Views\_ViewImports.cshtml"
using Northwind_PuntoDeVentaCore2019.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d19ae063b58052dba072b62e61701291f04fc9", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0486881e1309636e91e61f1c06379210ccdf3c08", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--
    NOMBRE:   WARLIN ANT. SANO BAEZ
    CORREO:   warlinsano@gmail.com
    TEL.:     829-329-0694
    CURSO:    Diseno y Desarrollo de Aplicasiones

    https://www.youtube.com/watch?v=GAQB7Y4X5fM&list=PLPl81lqbj-4J-gfAERGDCdOQtVgRhSvIT
  -->

<!DOCTYPE html>
<html lang=""es"">
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17d19ae063b58052dba072b62e61701291f04fc93705", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <title>vuejs</title>

    <meta name=author content=""warlin"">
    <meta name=keywords content=""nombre"">
    <meta name=description content=""Servidor Web"">

    <!-- comentarios -->
    <link rel=""stylesheet"" type=""text/css""");
                BeginWriteAttribute("href", " href=\"", 790, "\"", 797, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <!-- import CSS -->\n    <link rel=\"stylesheet\" href=\"https://unpkg.com/element-ui/lib/theme-chalk/index.css\">\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17d19ae063b58052dba072b62e61701291f04fc95302", async() => {
                WriteLiteral(@"
    <div id=""app"">
        <h1>{{titulo}}</h1>




        <table>
            <thead>
                <tr>
                    <th>
                        Id
                    </th>
                    <th>
                        Mascotas
                    </th>
                <tr>
            </thead>
            <tbody>
                <tr v-for=""(Datos, index) of tableData "">
                    <th>
                        {{index}}
                    </th>
                    <th>
                        {{Datos.companyName }}
                    </th>
                </tr>
            </tbody>
        </table>

        <ul>
            <li v-for=""item of arrayFruta "">{{item}}</li>
        </ul>

        <ul>
            <li v-for=""(Mascotas, index) of objMascotas "">
                {{Mascotas.nombre }} - {{Mascotas.estado }}
                <span v-if=""Mascotas.estado"">
                    - Estado falso
                </span>
                {{index}}
                <button v-on:click=""Agre");
                WriteLiteral("gar(index);\">Agregar</button>\n            </li>\n        </ul>\n\n        <componete1></componete1>\n\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!-- versión de desarrollo, incluye advertencias de ayuda en la consola -->
<script src=""https://cdn.jsdelivr.net/npm/vue/dist/vue.js""></script>
<script src=""https://unpkg.com/axios/dist/axios.min.js""></script>

<script>

    //const axios = require('axios');

    Vue.component('componete1', {
        template: `
               <div>Hola</div>
               `
    })

    const app = new Vue({
        el: '#app',
        data: {
            titulo: 'hola mundo vue',
            arrayFruta: ['manzana', 'pera', 'platano'],
            objMascotas: [
                { nombre: 'dominicana', estado: 'true' },
                { nombre: 'haiti', estado: 'false' },
                { nombre: 'benezuela', estado: 'true' }
            ],
            tableData: []
        },
        created: function () {
            this.SuplidorGetAll();
        },
        methods: {
            Agregar: function (index) {
                console.log(index);
            },
            Editar: function (index) {
                console");
            WriteLiteral(@".log(index);
            },
            Eliminar: function (index) {
                console.log(index);
            },
            SuplidorGetAll: function () {
                // Make a request for a user with a given ID
                axios.get('https://localhost:44326/api/SuppliersAPI')
                    .then(function (response) {
                        // handle success
                        console.log(response.data);
                        //this.tableData = response.data[1].companyName;
                        //console.log(app.tableData);
                        //app.tableData = response.data[1].companyName;
                        app.tableData = response.data;

                    })
                    .catch(function (error) {
                        // handle error
                        console.log(error);
                    })
                    .finally(function () {
                        // always executed
                    });
            }
        },
        computed: {

  ");
            WriteLiteral("      }\n\n    })\n\n</script>\n\n<!-- import JavaScript -->\n<script src=\"https://unpkg.com/element-ui/lib/index.js\"></script>\n<script src=\"https://cdn.jsdelivr.net/npm/sweetalert2@9\"></script>\n\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
