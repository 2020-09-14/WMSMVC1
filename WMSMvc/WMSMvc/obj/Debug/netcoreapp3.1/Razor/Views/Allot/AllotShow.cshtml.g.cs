#pragma checksum "E:\大二项目\WMSMVC\WMSMvc\WMSMvc\Views\Allot\AllotShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9404a8a31dd4492c12c5875566e5db1a504910c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Allot_AllotShow), @"mvc.1.0.view", @"/Views/Allot/AllotShow.cshtml")]
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
#line 1 "E:\大二项目\WMSMVC\WMSMvc\WMSMvc\Views\_ViewImports.cshtml"
using WMSMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\大二项目\WMSMVC\WMSMvc\WMSMvc\Views\_ViewImports.cshtml"
using WMSMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9404a8a31dd4492c12c5875566e5db1a504910c", @"/Views/Allot/AllotShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0683fd9041664bf11709a99e9a9062b0e2bf0ac1", @"/Views/_ViewImports.cshtml")]
    public class Views_Allot_AllotShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ElementUI/element-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vue.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/axios.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ElementUI/element-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\大二项目\WMSMVC\WMSMvc\WMSMvc\Views\Allot\AllotShow.cshtml"
  
    ViewData["Title"] = "AllotShow";
    Layout = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9404a8a31dd4492c12c5875566e5db1a504910c5019", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<h6>调拨单列表</h6>
<div id=""bb"">
    <span class=""de""></span>
    <el-form-item label=""调出仓库"">
        <el-select v-model=""outregion"" placeholder=""请选择仓库"">
            <el-option label=""仓库一"" value=""shanghai""></el-option>
            <el-option label=""仓库二"" value=""beijing""></el-option>
        </el-select>
    </el-form-item>
    <el-form-item label=""调入仓库"">
        <el-select v-model=""inregion"" placeholder=""全部"">
            <el-option label=""仓库一"" value=""shanghai""></el-option>
            <el-option label=""仓库二"" value=""beijing""></el-option>
        </el-select>
    </el-form-item>
    <span>商品名称：</span><el-input v-model=""aaa"" placeholder=""请输入"" style=""width:200px""></el-input>
    <span>商品编码：</span><el-input v-model=""bbb"" placeholder=""请输入"" style=""width:200px""></el-input>
    <el-form-item label=""审批状态"">
        <el-select v-model=""State"" placeholder=""全部"">
            <el-option label=""状态一"" value=""shanghai""></el-option>
            <el-option label=""状态二"" value=""beijing""></el-option>
        </el-sele");
            WriteLiteral(@"ct>
    </el-form-item>
    <span class=""demonstration"">调拨日期</span>
    <el-date-picker v-model=""value1""
                    type=""daterange""
                    range-separator=""至""
                    start-placeholder=""开始日期""
                    end-placeholder=""结束日期"">
    </el-date-picker>
    <span>调拨单号：</span><el-input v-model=""ccc"" placeholder=""请输入"" style=""width:200px""></el-input>
    <el-button type=""primary"" v-on:click=""Show()"" icon=""el-icon-search"">搜索</el-button>
    <el-button type=""primary"" v-on:click=""Dy()"" icon=""el-icon-search"">打印</el-button>
    <template>
        <el-table :data=""tableData""
                  style=""width: 100%"">
            <el-table-column prop=""aId""
                             label=""序号""
                             width=""180"">
            </el-table-column>
            <el-table-column prop=""aRequisition""
                             label=""调拨单号""
                             width=""180"">
            </el-table-column>
            <el-table-column prop");
            WriteLiteral(@"=""aCallout""
                             label=""调出仓库""
                             width=""180"">
            </el-table-column>
            <el-table-column prop=""aFold""
                             label=""调入仓库""
                             width=""180"">
            </el-table-column>
            <el-table-column prop=""aPerson""
                             label=""调拨人""
                             width=""180"">
            </el-table-column>
            <el-table-column prop=""aDate""
                             label=""调拨日期""
                             width=""190"">
            </el-table-column>
            <el-table-column prop=""aAuditstatus""
                             label=""审核状态""
                             width=""180"">
                <template slot-scope=""scope"">
                    <p v-if=""scope.row.aAuditstatus==0"">待审核</p>
                    <p v-if=""scope.row.aAuditstatus==1"">已审核</p>
                </template>
            </el-table-column>
            <el-table-column prop=""");
            WriteLiteral(@"aAllocatingstate""
                             label=""调拨状态""
                             width=""180"">
                <template slot-scope=""scope"">
                    <p v-if=""scope.row.aAllocatingstate==0"">未出库</p>
                    <p v-if=""scope.row.aAllocatingstate==1"">部分出库</p>
                    <p v-if=""scope.row.aAllocatingstate==2"">已出库</p>
                </template>
            </el-table-column>
            <el-table-column label=""操作"">
                <template slot-scope=""scope"">
                    <el-button v-on:click=""aa()"" size=""mini"" type=""primary"">任务详情</el-button>
                </template>
            </el-table-column>

        </el-table>
        <el-pagination v-on:size-change=""handleSizeChange""
                       v-on:current-change=""handleCurrentChange""
                       :current-page=""pageIndex""
                       :page-sizes=""[3, 10, 15, 20]""
                       :page-size=""100""
                       layout=""total, sizes, prev, pager, next, j");
            WriteLiteral("umper\"\r\n                       :total=\"totalCount\">\r\n        </el-pagination>\r\n    </template>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9404a8a31dd4492c12c5875566e5db1a504910c10645", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9404a8a31dd4492c12c5875566e5db1a504910c11685", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9404a8a31dd4492c12c5875566e5db1a504910c12725", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    var Vue = new Vue({
        el: ""#bb"",
        data: {
            tableData: '',
            tableData2: '',
            addFormVisible: false,
            XiangFormVisible: false,
            outregion: '',
            inregion: '',
            State:'',
            aaa: '',
            bbb: '',
            ccc: '',
            value1: '',
            region: '',
            XId:'',
            pageIndex: 1,
            pageSize: 3,
            totalCount: 11,
        },
        methods: {
            Show() {
                var _this = this
                axios
                    .get('http://localhost:3687/api/AllotShow?pageIndex=' + this.pageIndex + '&pageSize=' + this.pageSize)
                    .then(response => { this.tableData = response.data.allot_list, this.totalCount = response.data.totalCount })
                    .catch(function (error) {
                        console.log(error);
                    });

            },
            //初始页pageI");
            WriteLiteral(@"ndex、初始每页数据pageSize和数据data
            handleSizeChange: function (size) {
                this.pageSize = size;
                console.log(this.pageSize)//每页下拉
                this.Show(this.pageSize);
            },
            handleCurrentChange: function (pageIndex) {
                this.pageIndex = pageIndex;
                console.log(this.pageIndex);
                this.Show(this.pageIndex);
            },
        },
        mounted() {
            this.Show(this.pageIndex);
        }
    })

    function Dy() {
        window.print();
    }
    function aa() {
        location.href = ""/Allot/ItemdetailShow"";
    }

</script>













");
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
