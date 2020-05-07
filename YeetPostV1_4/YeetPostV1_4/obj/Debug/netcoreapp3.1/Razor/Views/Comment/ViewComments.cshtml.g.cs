#pragma checksum "R:\GitHubYeetPost\YeetPostV1_4\YeetPostV1_4\Views\Comment\ViewComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bedc02a42aa63ee05cc2def687b16256cf491d99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_ViewComments), @"mvc.1.0.view", @"/Views/Comment/ViewComments.cshtml")]
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
#line 1 "R:\GitHubYeetPost\YeetPostV1_4\YeetPostV1_4\Views\_ViewImports.cshtml"
using YeetPostV1_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "R:\GitHubYeetPost\YeetPostV1_4\YeetPostV1_4\Views\_ViewImports.cshtml"
using YeetPostV1_4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "R:\GitHubYeetPost\YeetPostV1_4\YeetPostV1_4\Views\Comment\ViewComments.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bedc02a42aa63ee05cc2def687b16256cf491d99", @"/Views/Comment/ViewComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c20e8b24b54daa629e99b9f7a1687b52b8e46db", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_ViewComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YeetPostV1_4.ViewModel.CommentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CommentPage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<script>\n    var model = ");
#nullable restore
#line 6 "R:\GitHubYeetPost\YeetPostV1_4\YeetPostV1_4\Views\Comment\ViewComments.cshtml"
           Write(Html.Raw(JsonConvert.SerializeObject(Model)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

</script>



<div id=""app"">
    <v-app id=""inspire"">

        <v-card class=""mx-auto""
                color=""#26c6da""
                dark
                max-width=""600"">

            <v-card-title>


                <v-list-item-content>
                    <v-list-item-title> &nbsp; {{model.yeet.username}}</v-list-item-title>
                </v-list-item-content>

                <v-list-item-content>
                    <v-list-item-title> &nbsp; <strong> <b>{{model.yeet.header}}</b> </strong></v-list-item-title>
                </v-list-item-content>
                <v-list-item-content>
                    <v-list-item-title> &nbsp; {{model.yeet.date}}</v-list-item-title>
                </v-list-item-content>

                <v-list-item-content>
                    <v-list-item-title> &nbsp; {{model.yeet.location}}</v-list-item-title>
                </v-list-item-content>

                <v-dialog v-if=""model.yeet.isMine == true"" v-model=""model.yeet.deleteModal"" persistent max");
            WriteLiteral(@"-width=""290"">
                    <template v-slot:activator=""{ on }"">
                        <v-list-item-content>
                            <v-icon class=""mr-1"" color=""red"" v-on=""on"">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; mdi-delete</v-icon>
                        </v-list-item-content>
                    </template>
                    <v-card>
                        <div>
                            <v-card-title class=""headline"" style=""text-align: center;"">Are you sure you want to deYeet this Yeet?</v-card-title>
                            <v-card-actions>
                                <v-spacer></v-spacer>
                                <v-btn color=""green darken-1"" text v-on:click=""model.yeet.deleteModal = false"">Close</v-btn>
                                <v-btn color=""green darken-1"" text
                                       v-on:click=""deleteYeet(model.yeet.yeetID, model.yeet.location)"">Yes</v-btn>
                            </v-card-actions>
                        </div>");
            WriteLiteral(@"
                        <div>

                        </div>
                    </v-card>
                </v-dialog>




                <v-dialog v-if=""model.yeet.iFlagged == true && model.yeet.isMine == false"" v-model=""model.yeet.modal"" persistent max-width=""290"">
                    <template v-slot:activator=""{ on }"">
                        <v-list-item-content>
                            <v-icon class=""mr-1"" color=""red"" v-on=""on"">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; mdi-flag</v-icon>

                        </v-list-item-content>
                    </template>
                    <v-card>
                        <div>
                            <v-card-title class=""headline"" style=""text-align: center;"">Unflag Yeet? {{model.yeet.yeetID}}</v-card-title>

                            <v-card-actions>
                                <v-spacer></v-spacer>
                                <v-btn color=""green darken-1"" text v-on:click=""yeet.modal = false"">Close</v-btn>
              ");
            WriteLiteral(@"                  <v-btn color=""green darken-1"" text
                                       v-on:click=""flagYeet(model.yeet.yeetID, model.yeet.whoFlags,true, yeet, model.yeet.location )"">Yes</v-btn>
                            </v-card-actions>
                        </div>
                        <div>

                        </div>
                    </v-card>
                </v-dialog>

                <v-dialog v-model=""model.yeet.modal"" persistent max-width=""290"" v-if=""model.yeet.iFlagged == false && model.yeet.isMine == false"">
                    <template v-slot:activator=""{ on }"">
                        <v-list-item-content>

                            <v-icon class=""mr-1"" color=""white"" v-on=""on"">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; mdi-flag</v-icon>
                        </v-list-item-content>
                    </template>
                    <v-card>
                        <v-card-title class=""headline"" style=""text-align: center;"">Flag for What?</v-card-title>

        ");
            WriteLiteral(@"                <v-row>
                            <v-col cols=""12"">
                                <v-divider></v-divider>
                                <v-card-text style=""font-size: 32px; text-align: center;""
                                             v-on:click=""flagYeet(model.yeet.yeetID, model.yeet.whoFlags,false, inappropriate ,model.yeet.location )"">Innapropriate Context</v-card-text>
                                <v-divider></v-divider>
                            </v-col>
                            <v-col cols=""12"">
                                <v-card-text style=""font-size: 32px;text-align: center;""
                                             v-on:click=""flagYeet(model.yeet.yeetID, model.yeet.whoFlags,false, abusive ,model.yeet.location )"">Abusive</v-card-text>
                                <v-divider></v-divider>
                            </v-col>

                        </v-row>
                        <v-card-actions>
                            <v-spacer></v-spa");
            WriteLiteral(@"cer>
                            <v-btn color=""green darken-1"" text v-on:click=""yeet.modal = false"">Close</v-btn>
                        </v-card-actions>
                    </v-card>
                </v-dialog>



            </v-card-title>

            <v-card-text class=""headline font-weight-bold"">
                ""   {{model.yeet.yeet}} ""
            </v-card-text>

            <v-card-actions>
                <v-list-item class=""grow"">

                    <v-row align=""center""
                           justify=""end"">
                        <v-icon class=""mr-1"" color=""red"" v-if=""model.yeet.iLiked == true"" v-on:click=""likeYeet(model.yeet.yeetID, model.yeet.whoLikes, model.yeet.location, true)"">mdi-heart</v-icon>

                        <v-icon class=""mr-1"" v-if=""model.yeet.iLiked == false && model.showComments == true"" v-on:click=""likeYeet(model.yeet.yeetID, model.yeet.whoLikes, model.location, false)"">mdi-heart</v-icon>


                        <span class=""subheading mr-2"">{{mod");
            WriteLiteral("el.yeet.totalLikes}}</span>\r\n\r\n                    </v-row>\r\n                </v-list-item>\r\n            </v-card-actions>\n\n        </v-card>\n        <br />\n    </v-app>\n\n\n\n\n\n");
            WriteLiteral(@"    <v-app id=""inspire"">
        <v-card max-width=""500""
                class=""mx-auto"" v-if=""model.showComments == true"">
            <v-form ref=""form"" v-on:submit.prevent=""submit"">
                <v-card color=""white"">

                    <v-container fluid>
                        <v-row>


                            <v-col cols=""12"">
                                <v-textarea v-model=""addComment""
                                            label=""comment ""
                                            id=""comment""
                                            color=""black""
                                            rows=""3"">
                                    <template v-slot:label>
                                        <div>
                                            Comment <small>(say something dumb)</small>
                                        </div>
                                    </template>
                                </v-textarea>

                            </v-col>

          ");
            WriteLiteral(@"                  <v-col cols=""9"">
                            </v-col>
                            <v-col cols=""3"">
                                <v-btn color=""rgb(147, 230, 234)"" v-on:click=""submit"">
                                    comment
                                </v-btn>
                            </v-col>
                        </v-row>
                    </v-container>

                </v-card>
            </v-form>

            <v-list two-line>
                <v-list-item-group>
                    <template v-for=""(item, index) in model.comments"">
                        <v-list-item :key=""item.title"">
                            <template v-slot:default=""{active, toggle }"">

                                <v-list-item-content>

                                    <v-list-item-title style=""color:black; font-weight: bold; "">
                                        &nbsp; {{item.username}}
                                    </v-list-item-title>
                                    <v");
            WriteLiteral(@"-list-item-subtitle style=""color:black; font-size: 15px; "">
                                        &nbsp; "" {{item.comment}} ""
                                    </v-list-item-subtitle>
                                </v-list-item-content>


                            </template>
                        </v-list-item>

                        <v-divider v-if=""index + 1 < model.comments.length""
                                   :key=""index""></v-divider>
                    </template>
                </v-list-item-group>
            </v-list>
        </v-card>
    </v-app>

</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bedc02a42aa63ee05cc2def687b16256cf491d9913431", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YeetPostV1_4.ViewModel.CommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
