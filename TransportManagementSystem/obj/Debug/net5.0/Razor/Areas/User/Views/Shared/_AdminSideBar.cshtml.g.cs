#pragma checksum "C:\Users\David\Desktop\UNI\CSC\Advanced Programming Project\TransportManagementSystem\TransportManagementSystem\Areas\User\Views\Shared\_AdminSideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d45f46feabc8e10ebdd9472677fd6d75cfc97a99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Shared__AdminSideBar), @"mvc.1.0.view", @"/Areas/User/Views/Shared/_AdminSideBar.cshtml")]
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
#line 1 "C:\Users\David\Desktop\UNI\CSC\Advanced Programming Project\TransportManagementSystem\TransportManagementSystem\Areas\User\Views\_ViewImports.cshtml"
using TransportManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\David\Desktop\UNI\CSC\Advanced Programming Project\TransportManagementSystem\TransportManagementSystem\Areas\User\Views\_ViewImports.cshtml"
using TransportManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\David\Desktop\UNI\CSC\Advanced Programming Project\TransportManagementSystem\TransportManagementSystem\Areas\User\Views\_ViewImports.cshtml"
using TransportManagementSystem.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d45f46feabc8e10ebdd9472677fd6d75cfc97a99", @"/Areas/User/Views/Shared/_AdminSideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd4b43b3bcf44d4eba24c565ea19e8fce51457a2", @"/Areas/User/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_User_Views_Shared__AdminSideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/default-user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("LogoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .badge-count {
        padding: 6px 10px !important;
    }

    .nav-item {
        padding: 5px;
    }
</style>
<div class=""sidebar"">
    <!--
        Tip 1: You can change the background color of the sidebar using: data-background-color=""black | dark | blue | purple | light-blue | green | orange | red""
        Tip 2: you can also add an image using data-image attribute
    -->

    <div class=""sidebar-background""></div>
    <div class=""sidebar-wrapper scrollbar-inner"">
        <div class=""sidebar-content"">
            <div class=""user"">
                <div class=""photo"">
");
            WriteLiteral("              \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d45f46feabc8e10ebdd9472677fd6d75cfc97a996400", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                </div>
                <div class=""info"">
                    <a data-toggle=""collapse"" href=""#collapseExample"" aria-expanded=""true"">
                        <span>
                           UserName

                            <span class=""user-level"">Supper Admin</span>
                            <span class=""caret""></span>
                        </span>
                    </a>
                    <div class=""clearfix""></div>
                    <div class=""collapse in"" id=""collapseExample"">
                        <ul class=""nav"">
                            <li>
                                <a href=""/Advertisers/UpdateProfile"">
                                    <span class=""link-collapse"">My Profile</span>
                                </a>
                            </li>
                            <li>
                               

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d45f46feabc8e10ebdd9472677fd6d75cfc97a998387", async() => {
                WriteLiteral("\r\n                              \r\n                                <a onclick=\"$(\'#LogoutForm\').submit();\"><span class=\"link-collapse\">Log out</span></a>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\David\Desktop\UNI\CSC\Advanced Programming Project\TransportManagementSystem\TransportManagementSystem\Areas\User\Views\Shared\_AdminSideBar.cshtml"
                                                                                                                              WriteLiteral(Url.Action("Index", "Home", new { area = "" }));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <ul class=""nav navigation"">



                <li class=""nav-item"" id=""Dashboard"">
                    <a href=""/admin/"">
                        <i class=""la la-dashboard""></i>
                        <p>
                            Dashboard
                        </p>
                    </a>
                </li>



                <li id=""HomePage"" class=""nav-item"">
                    <a data-toggle=""collapse"" href=""#HomePageDiv"">
                        <i class=""fa fa-home""></i>
                        <p>Home Page</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""HomePageDiv"">
                        <ul class=""nav nav-collapse"">

                            <li id=""Banners"">
                                <a href=""/admin/banners"">

           ");
            WriteLiteral(@"                         <span class=""sub-item"">Banners</span>


                                </a>
                            </li>
                            <li id=""Welcome"">
                                <a href=""/admin/welcome"">

                                    <span class=""sub-item"">Welcome</span>
                                </a>
                            </li>
                            <li id=""Glance"">
                                <a href=""/admin/glance"">

                                    <span class=""sub-item"">Glance</span>
                                </a>
                            </li>
                            <li id=""Why"">
                                <a href=""/admin/why"">
                                    <span class=""sub-item"">Why Inhealth</span>
                                </a>
                            </li>

                        </ul>
                    </div>
                </li>

                <li id=""AboutPage"" cl");
            WriteLiteral(@"ass=""nav-item"">
                    <a data-toggle=""collapse"" href=""#AboutPageDiv"">
                        <i class=""far fa-address-card""></i>
                        <p>About</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""AboutPageDiv"">
                        <ul class=""nav nav-collapse"">

                            <li id=""Company"">
                                <a href=""/admin/aboutcompany"">

                                    <span class=""sub-item"">Company</span>


                                </a>
                            </li>
                            <li id=""Careers"">
                                <a href=""/admin/careers"">

                                    <span class=""sub-item"">Careers</span>
                                </a>
                            </li>

                        </ul>
                    </div>
                </li>


                <li id=""Products");
            WriteLiteral(@"Page"" class=""nav-item"">
                    <a data-toggle=""collapse"" href=""#ProductsPageDiv"">
                        <i class=""fas fa-store""></i>
                        <p>Products</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""ProductsPageDiv"">
                        <ul class=""nav nav-collapse"">
                            <li id=""AddNewProduct"">
                                <a href=""#"">

                                    <span class=""sub-item"">Add New</span>
                                </a>
                            </li>

                            <li id=""AllProducts"">
                                <a href=""#"">

                                    <span class=""sub-item"">All Products</span>


                                </a>
                            </li>

                        </ul>
                    </div>
                </li>


                <li id=""ResourcesPage""");
            WriteLiteral(@" class=""nav-item"">
                    <a data-toggle=""collapse"" href=""#ResourcesPageDiv"">
                        <i class=""fas fa-users-cog""></i>
                        <p>Resources</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""ResourcesPageDiv"">
                        <ul class=""nav nav-collapse"">
                            <li id=""AddNewResources"">
                                <a href=""#"">

                                    <span class=""sub-item"">Add New</span>
                                </a>
                            </li>

                            <li id=""AllResources"">
                                <a href=""#"">

                                    <span class=""sub-item"">All Resources</span>


                                </a>
                            </li>

                        </ul>
                    </div>
                </li>



                <li id=""Partne");
            WriteLiteral(@"rsPage"" class=""nav-item"">
                    <a data-toggle=""collapse"" href=""#PartnersPageDiv"">
                        <i class=""far fa-handshake""></i>
                        <p>Partners</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""PartnersPageDiv"">
                        <ul class=""nav nav-collapse"">
                            <li id=""AddNewPartners"">
                                <a href=""#"">

                                    <span class=""sub-item"">Add New</span>
                                </a>
                            </li>

                            <li id=""AllPartners"">
                                <a href=""#"">

                                    <span class=""sub-item"">All Partners</span>


                                </a>
                            </li>

                        </ul>
                    </div>
                </li>



                <li id=""FAQPa");
            WriteLiteral(@"ge"" class=""nav-item"">
                    <a data-toggle=""collapse"" href=""#FAQPageDiv"">
                        <i class=""far fa-question-circle""></i>
                        <p>FAQ</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""FAQPageDiv"">
                        <ul class=""nav nav-collapse"">
                            <li id=""AddNewPartners"">
                                <a href=""#"">

                                    <span class=""sub-item"">Add New</span>
                                </a>
                            </li>

                            <li id=""AllPartners"">
                                <a href=""#"">

                                    <span class=""sub-item"">All FAQs</span>


                                </a>
                            </li>

                        </ul>
                    </div>
                </li>

                <li id=""ContactPage"" class=""nav-it");
            WriteLiteral(@"em"">
                    <a data-toggle=""collapse"" href=""#ContactPageDiv"">
                        <i class=""fas fa-phone-volume""></i>
                        <p>Contact</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""ContactPageDiv"">
                        <ul class=""nav nav-collapse"">
                            <li id=""ContactInfo"">
                                <a href=""/admin/contactinfo"">

                                    <span class=""sub-item"">Contact Info</span>
                                </a>
                            </li>

                            <li id=""Messages"">
                                <a href=""/admin/messages"">

                                    <span class=""sub-item"">Messages</span>


                                </a>
                            </li>

                        </ul>
                    </div>
                </li>


                <li id=""Pa");
            WriteLiteral(@"tientPage"" class=""nav-item"">
                    <a data-toggle=""collapse"" href=""#PatientPageDiv"">
                        <i class=""#""></i>
                        <p>Patient</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""PatientPageDiv"">
                        <ul class=""nav nav-collapse"">

                            <li id=""patients"">
                                <a href=""/admin/Patients"">
                                    <span class=""sub-item"">Patients</span>
                                </a>
                            </li>

");
            WriteLiteral(@"
                        </ul>
                    </div>
                </li>


            </ul>
        </div>
    </div>
</div>
<script>
    var pathname = window.location.pathname.split('/');
    var ControllerName = pathname[1];
    var ViewName = pathname[2];


    $(""#"" + ViewName).addClass(""active"");
    if (ViewName == ""Products"" || ViewName == ""MainCategories"" || ViewName == ""Deals"" || ViewName == ""ProductCategories"") {
        $(""#"" + ""AdminProd"").addClass(""active"");
        $(""#"" + ""AdminProd"" + ""Div"").addClass(""show"");
    }
    if (ViewName == ""CreateMainCategory"" || ViewName == ""EditMainCategory"") {
        $(""#"" + ""MainCategories"").addClass(""active"");
        $(""#"" + ""AdminProd"").addClass(""active"");
        $(""#"" + ""AdminProd"" + ""Div"").addClass(""show"");
    }


    if (ViewName == ""CreateProductCategories"" || ViewName == ""EditSubCategory"") {
        $(""#"" + ""ProductCategories"").addClass(""active"");
        $(""#"" + ""AdminProd"").addClass(""active"");
        $(""#"" +");
            WriteLiteral(@" ""AdminProd"" + ""Div"").addClass(""show"");
    }


    if (ViewName == ""CreateBrand"" || ViewName == ""EditBrand"") {
        $(""#"" + ""Brands"").addClass(""active"");
        $(""#"" + ""AdminProd"").addClass(""active"");
        $(""#"" + ""AdminProd"" + ""Div"").addClass(""show"");
    }


    if (ViewName == ""CreateProduct"" || ViewName == ""EditProduct"") {
        $(""#"" + ""Products"").addClass(""active"");
        $(""#"" + ""AdminProd"").addClass(""active"");
        $(""#"" + ""AdminProd"" + ""Div"").addClass(""show"");
    }



    if (ViewName == ""CreateDeal"" || ViewName == ""EditDeal"") {
        $(""#"" + ""Deals"").addClass(""active"");
        $(""#"" + ""AdminProd"").addClass(""active"");
        $(""#"" + ""AdminProd"" + ""Div"").addClass(""show"");
    }


    if (ViewName == ""SuperAdmin"") {
        $(""#"" + ""Dashboard"").addClass(""active"");
        $(""#"" + ""Dashboard"").addClass(""active"");
        $(""#"" + ""Dashboard"" + ""Div"").addClass(""show"");
    }



    //$(""#"" + ControllerName).addClass(""active"");
    //$(""#"" + Controlle");
            WriteLiteral("rName + \"Div\").addClass(\"show\");\r\n\r\n\r\n</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591