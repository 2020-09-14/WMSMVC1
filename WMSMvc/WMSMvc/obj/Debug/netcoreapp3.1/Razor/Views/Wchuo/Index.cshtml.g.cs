#pragma checksum "C:\Users\86176\Desktop\WMA_mvc\WMSMvc\WMSMvc\Views\Wchuo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "944c9f3eff3dc1a12b6cd170db169fa786e1327f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wchuo_Index), @"mvc.1.0.view", @"/Views/Wchuo/Index.cshtml")]
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
#line 1 "C:\Users\86176\Desktop\WMA_mvc\WMSMvc\WMSMvc\Views\_ViewImports.cshtml"
using WMSMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\86176\Desktop\WMA_mvc\WMSMvc\WMSMvc\Views\_ViewImports.cshtml"
using WMSMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"944c9f3eff3dc1a12b6cd170db169fa786e1327f", @"/Views/Wchuo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0683fd9041664bf11709a99e9a9062b0e2bf0ac1", @"/Views/_ViewImports.cshtml")]
    public class Views_Wchuo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ElementUI/element-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vue.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/axios.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ElementUI/Index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\86176\Desktop\WMA_mvc\WMSMvc\WMSMvc\Views\Wchuo\Index.cshtml"
  

    Layout = null;


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "944c9f3eff3dc1a12b6cd170db169fa786e1327f4985", async() => {
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
<div id=""tb"">
    <span>采购订单号：</span><el-input v-model=""aaa"" placeholder=""请输入"" style=""width:200px""></el-input>
    <span>供应商：</span><el-input v-model=""bbb"" placeholder=""请输入"" style=""width:200px""></el-input>
    <span class=""demonstration"">采购日期</span>
    <el-date-picker v-model=""value1""
                    type=""daterange""
                    range-separator=""至""
                    start-placeholder=""开始日期""
                    end-placeholder=""结束日期"">
    </el-date-picker>
    <el-button type=""primary"" v-on:click=""Show()"" icon=""el-icon-search"">搜索</el-button>
    <template>
        <el-table :data=""tableData""
                  style=""width: 100%"">
            <el-table-column prop=""shCoding""
                             label=""编号""
                             width=""180"">
            </el-table-column>
            <el-table-column prop=""createtime""
                             label=""任务下达时间""
                             width=""200"">

            </el-table-column>
            <el-table-co");
            WriteLiteral("lumn prop=\"cause\"\r\n                             label=\"出库原因\"\r\n                             width=\"180\">\r\n\r\n            </el-table-column>\r\n            <el-table-column");
            BeginWriteAttribute("prop", " prop=\"", 1284, "\"", 1291, 0);
            EndWriteAttribute();
            BeginWriteAttribute("label", "\r\n                             label=\"", 1292, "\"", 1330, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                             width=""180"">

            </el-table-column>
            <el-table-column label=""出库状态""
                             width=""180"">
                <template slot-scope=""scope"">
                    <p v-if=""scope.row.state==0"">已出库</p>
                    <p v-if=""scope.row.state==1"">未出库</p>
                </template>
            </el-table-column>
            <el-table-column prop=""article""
                             label=""物品""
                             width=""180"">
            </el-table-column>
            <el-table-column prop=""shsum""
                             label=""任务数量""
                             width=""180"">
            </el-table-column>
            <el-table-column label=""操作"">
                <template slot-scope=""scope"">
                    <el-button v-on:click=""Xiangqing(scope.row)"" size=""mini"" type=""primary"">任务详情</el-button>
                </template>
            </el-table-column>
        </el-table>
        <el-pagination v-on:size");
            WriteLiteral(@"-change=""handleSizeChange""
                       v-on:current-change=""handleCurrentChange""
                       :current-page=""pageIndex""
                       :page-sizes=""[3, 10, 15, 20]""
                       :page-size=""100""
                       layout=""total, sizes, prev, pager, next, jumper""
                       :total=""totalCount"">
        </el-pagination>
    </template>
    <el-dialog title=""查看详情"" :visible.sync=""XiangFormVisible"">

        <template>
            <el-table :data=""tableData2""
                      style=""width: 100%"">
                <el-table-column prop=""goCoding""
                                 label=""商品编号""
                                 width=""180"">
                </el-table-column>
                <el-table-column prop=""goName""
                                 label=""商品名称""
                                 width=""180"">
                </el-table-column>
                <el-table-column prop=""gosum""
                                 label=""商品数量""
 ");
            WriteLiteral(@"                                width=""180"">
                </el-table-column>
                <el-table-column prop=""goSpecification""
                                 label=""规格""
                                 width=""180"">
                </el-table-column>
            </el-table>
        </template>

        <div>
            <el-button v-on:click=""cancel()"">取消</el-button>
            <el-button type=""primary"" v-on:click=""sumbitXiangRow()"">确定</el-button>
        </div>
    </el-dialog>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "944c9f3eff3dc1a12b6cd170db169fa786e1327f10381", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "944c9f3eff3dc1a12b6cd170db169fa786e1327f11421", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "944c9f3eff3dc1a12b6cd170db169fa786e1327f12461", async() => {
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
    new Vue({
        el: ""#tb"",
        data: {
            tableData: '',
            editFormVisible: false,
            XiangFormVisible: false,//是否显示编辑窗口
            formLabelWidth: '120px',
            pageIndex: 1,
            pageSize: 3,
            totalCount: 11,
            tableData2: '',
            aaa: '',
            bbb: '',
            value1: '',
        },
        methods: {
            Show() {
                var _this = this
                axios
                    .get('http://localhost:3687/api/Rshow?pageIndex=' + this.pageIndex + '&pageSize=' + this.pageSize + '&aaa=' + this.aaa + ""&time="" + this.value1)
                    .then(response => { this.tableData = response.data.eX_Renwus_list, this.totalCount = response.data.totalCount })
                    .catch(function (error) {
                        console.log(error);
                    });
            },
            //初始页pageIndex、初始每页数据pageSize和数据data
            handleSizeChange: funct");
            WriteLiteral(@"ion (size) {
                this.pageSize = size;
                console.log(this.pageSize)//每页下拉
                this.Show(this.pageSize);
            },
            handleCurrentChange: function (pageIndex) {
                this.pageIndex = pageIndex;
                console.log(this.pageIndex);
                this.Show(this.pageIndex);
            },
            Xiangqing(row) {
                this.XId = row.shipmentId,
                    console.log(this.XId);
                this.show2();
                this.XiangFormVisible = true

            },
            show2() {
                var _this = this
                axios
                    .get('http://localhost:3687/api/Ex_GoodsShow?ids=' + this.XId)
                    .then(function (res) {
                        console.log(res);
                        _this.tableData2 = res.data

                    })
                    .catch(function (error) {
                        console.log(error);
                   ");
            WriteLiteral(" });\r\n            },\r\n        },\r\n        mounted() {\r\n            this.Show();\r\n        }\r\n    })\r\n</script>");
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
