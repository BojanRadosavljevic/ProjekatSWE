#pragma checksum "C:\Users\bojan\Documents\si.22.50.beauty_code\Aplikacija\Pages\ZaposleniProfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66748a6cfd0d8e83ef6074dd0ae108ad78e7e973"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_ZaposleniProfil), @"mvc.1.0.razor-page", @"/Pages/ZaposleniProfil.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66748a6cfd0d8e83ef6074dd0ae108ad78e7e973", @"/Pages/ZaposleniProfil.cshtml")]
    public class Pages_ZaposleniProfil : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\bojan\Documents\si.22.50.beauty_code\Aplikacija\Pages\ZaposleniProfil.cshtml"
  
    Layout = "_LayoutZaposleni";
    ViewData["Title"]="Zaposleni";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <main id=""main"" class=""main"">

    <div class=""pagetitle"">
      <h1>Profil</h1>
      <nav>
        <ol class=""breadcrumb"">
          <li class=""breadcrumb-item""><a href=""./Zaposleni"">Početna</a></li>
          <li class=""breadcrumb-item"">Profil</li>
          <li class=""breadcrumb-item active"">Moj profil</li>
        </ol>
      </nav>
    </div><!-- End Page Title -->

    <section class=""section profile"">
      <div class=""row"">
        <div class=""col-xl-4"">

          <div class=""card"">
            <div class=""card-body profile-card pt-4 d-flex flex-column align-items-center"">

              <h2 id=""section-userzap""></h2>
              <h3 id=""section-userzap-tip""></h3>
          
            </div>
          </div>
        </div>
          <div class=""col-xl-8"">
          <div class=""card"">
            <div class=""card-body pt-3"">
              <!-- Bordered Tabs -->
              <ul class=""nav nav-tabs nav-tabs-bordered"">
                <li class=""nav-item"">
       ");
            WriteLiteral(@"           <button class=""nav-link active"" data-bs-toggle=""tab"" data-bs-target=""#profile-overview"">Pregled</button>
                </li>
                <li class=""nav-item"">
                  <button class=""nav-link"" data-bs-toggle=""tab"" data-bs-target=""#profile-edit"">Izmeni profil</button>
                </li>
                <li class=""nav-item"">
                  <button class=""nav-link"" data-bs-toggle=""tab"" data-bs-target=""#profile-change-password"">Promeni lozinku</button>
                </li>
              </ul>
              <div class=""tab-content pt-2"">

                <div class=""tab-pane fade show active profile-overview"" id=""profile-overview"">
                  <h5 class=""card-title"">Detalji</h5>
                  <div class=""row"">
                    <div class=""col-lg-3 col-md-4 label "">Puno ime i prezime</div>
                    <div class=""col-lg-9 col-md-8"" id=""fullNamezap""></div>
                  </div>
                  <div class=""row"">
                    <div clas");
            WriteLiteral(@"s=""col-lg-3 col-md-4 label"">Broj telefona</div>
                    <div class=""col-lg-9 col-md-8"" id=""brtelzap""></div>
                  </div>
                  <div class=""row"">
                    <div class=""col-lg-3 col-md-4 label"">Adresa</div>
                    <div class=""col-lg-9 col-md-8"" id=""adresazap""></div>
                  </div>
                  <div class=""row"">
                    <div class=""col-lg-3 col-md-4 label"">Godina zaposlenja</div>
                    <div class=""col-lg-9 col-md-8"" id=""godzapzap""></div>
                  </div>
                  <div class=""row"">
                    <div class=""col-lg-3 col-md-4 label"">Datum rođenja</div>
                    <div class=""col-lg-9 col-md-8"" id=""datrodjzap""></div>
                  </div>
                  <div class=""row"">
                    <div class=""col-lg-3 col-md-4 label"">Email</div>
                    <div class=""col-lg-9 col-md-8"" id=""emailzap""></div>
                  </div>
                  <div clas");
            WriteLiteral(@"s=""row"">
                    <div class=""col-lg-3 col-md-4 label"">Korisničko ime</div>
                    <div class=""col-lg-9 col-md-8"" id=""korimezap""></div>
                  </div>
                  <div class=""row"">
                    <div class=""col-lg-3 col-md-4 label"">Škola</div>
                    <div class=""col-lg-9 col-md-8"" id=""skolazap""></div>
                  </div>
                  <div class=""row"">
                    <div class=""col-lg-3 col-md-4 label"">Plata</div>
                    <div class=""col-lg-9 col-md-8"" id=""platazap""></div>
                  </div>
                  <div class=""row"">
                    <div class=""col-lg-3 col-md-4 label"">Tip radnika</div>
                    <div class=""col-lg-9 col-md-8"" id=""tipradzap""></div>
                  </div>
                </div>
                <div class=""tab-pane fade profile-edit pt-3"" id=""profile-edit"">
                  <!-- Profile Edit Form -->
                  <form onsubmit=""return false"">
         ");
            WriteLiteral(@"           
                    <div class=""row mb-3"">
                      <label for=""fullName"" class=""col-md-4 col-lg-3 col-form-label"">Ime</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""fullName"" type=""text"" class=""form-control"" id=""imeIzmenezap"" >
                      </div>
                    </div>
                    <div class=""row mb-3"">
                      <label for=""fullName"" class=""col-md-4 col-lg-3 col-form-label"">Prezime</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""fullName"" type=""text"" class=""form-control"" id=""prezimeIzmenezap"" >
                      </div>
                    </div>
                    <div class=""row mb-3"">
                      <label for=""Phone"" class=""col-md-4 col-lg-3 col-form-label"">Broj telefona</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""phone"" type=""text"" class=""form-control"" id=""izmenB");
            WriteLiteral(@"rTel"" >
                      </div>
                    </div>
                    <div class=""row mb-3"">
                      <label for=""Address"" class=""col-md-4 col-lg-3 col-form-label"">Adresa</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""address"" type=""text"" class=""form-control"" id=""izmenaAdrzap"" >
                      </div>
                    </div>
                    <div class=""row mb-3"">
                      <label for=""Phone"" class=""col-md-4 col-lg-3 col-form-label"">Datum rođenja</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""phone"" type=""text"" class=""form-control"" id=""izmenDatRodj"" >
                      </div>
                    </div>
                    <div class=""row mb-3"">
                      <label for=""Email"" class=""col-md-4 col-lg-3 col-form-label"">Email</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""email"" ");
            WriteLiteral(@"type=""email"" class=""form-control"" id=""izmenaEmail"" >
                      </div>
                    </div>
                    <div class=""row mb-3"">
                      <label for=""Email"" class=""col-md-4 col-lg-3 col-form-label"">Korisničko ime</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""email"" type=""username"" class=""form-control"" id=""korImeIzmena"" >
                      </div>
                    </div>
                    <div class=""row mb-3"">
                      <label for=""Email"" class=""col-md-4 col-lg-3 col-form-label"">Škola</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""email"" type=""username"" class=""form-control"" id=""izmenaSkola"" >
                      </div>
                    </div>
                    <div class=""text-center"">
                      <button type=""submit"" class=""btn btn-primary"" id=""izmenaRadnikProf"">Sačuvaj izmene</button>
                    </div>
  ");
            WriteLiteral(@"                </form><!-- End Profile Edit Form -->
                </div>
                <div class=""tab-pane fade pt-3"" id=""profile-settings"">
               <!-- Settings Form -->   
                </div>
                <div class=""tab-pane fade pt-3"" id=""profile-change-password"">
                  <!-- Change Password Form -->
                  <form onsubmit=""return false"">

                    <div class=""row mb-3"">
                      <label for=""currentPassword"" class=""col-md-4 col-lg-3 col-form-label"">Trenutna lozinka</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""password"" type=""password"" class=""form-control"" id=""currentPasswordzap"">
                      </div>
                    </div>

                    <div class=""row mb-3"">
                      <label for=""newPassword"" class=""col-md-4 col-lg-3 col-form-label"">Nova lozinka</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input ");
            WriteLiteral(@"name=""newpassword"" type=""password"" class=""form-control"" id=""newPasswordzap"">
                      </div>
                    </div>

                    <div class=""row mb-3"">
                      <label for=""renewPassword"" class=""col-md-4 col-lg-3 col-form-label"">Ponovo unesite lozinku</label>
                      <div class=""col-md-8 col-lg-9"">
                        <input name=""renewpassword"" type=""password"" class=""form-control"" id=""renewPasswordzap"">
                      </div>
                    </div>
                    <div class=""text-center"">
                      <button type=""submit"" class=""btn btn-primary"" id=""promeniLozR"">Promeni lozinku</button>
                    </div>
                  </form><!-- End Change Password Form -->
                </div>
              </div><!-- End Bordered Tabs -->
            </div>
          </div>
        </div>
      </div>
    </section>
  </main><!-- End #main -->
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <!-- Nase skripte-->\r\n    <script src=\"assetszaposleni/js/users-profile.js\" type=\"module\"></script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages.RadnikAuth> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages.RadnikAuth> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages.RadnikAuth>)PageContext?.ViewData;
        public Pages.RadnikAuth Model => ViewData.Model;
    }
}
#pragma warning restore 1591