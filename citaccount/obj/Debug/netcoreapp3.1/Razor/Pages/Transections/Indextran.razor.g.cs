#pragma checksum "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8531768873727a40c9cf3ff0ed28d2bd45ff572e"
// <auto-generated/>
#pragma warning disable 1591
namespace citaccount.Pages.Transections
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\citaccount\citaccount\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\citaccount\citaccount\_Imports.razor"
using citaccount;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\citaccount\citaccount\_Imports.razor"
using citaccount.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\citaccount\citaccount\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Oceanware.Ocean.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
using citaccount.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
using citaccount.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
using BlazorTable;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transection")]
    public partial class Indextran : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
 if (tran == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>ກຳລັງໂຫຼດຂໍ້ມູນ...</em></p>\r\n");
#nullable restore
#line 13 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<a class=\"btn btn-primary btn-sm\" href=\"/createtran\">ເພີ່ມໃໝ່</a>\r\n");
            __builder.AddContent(4, "    ");
            __builder.OpenComponent<BlazorTable.Table<TblTransection>>(5);
            __builder.AddAttribute(6, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TblTransection>>(
#nullable restore
#line 18 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                             tran

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                             10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ColumnReorder", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ShowSearchBar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ShowFooter", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblTransection>>(13);
                __builder2.AddAttribute(14, "Title", "ລດ");
                __builder2.AddAttribute(15, "Width", "2%");
                __builder2.AddAttribute(16, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTable.Align>(
#nullable restore
#line 19 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                        Align.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblTransection>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(18, "\r\n");
                    __builder3.AddContent(19, 
#nullable restore
#line 21 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                   RowNumber

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 21 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                            ; RowNumber++;

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(20, "            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblTransection>>(22);
                __builder2.AddAttribute(23, "Title", "ວັນທີ");
                __builder2.AddAttribute(24, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<TblTransection, System.Object>>>(
#nullable restore
#line 24 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                  x => x.CreateDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Format", "dd/MM/yyyy");
                __builder2.AddAttribute(26, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Width", "6%");
                __builder2.AddAttribute(28, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTable.Align>(
#nullable restore
#line 24 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                                                            Align.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblTransection>>(30);
                __builder2.AddAttribute(31, "Title", "ເລກທີ");
                __builder2.AddAttribute(32, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<TblTransection, System.Object>>>(
#nullable restore
#line 25 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                  x=>x.TranNo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Width", "5%");
                __builder2.AddAttribute(36, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTable.Align>(
#nullable restore
#line 25 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                                                    Align.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblTransection>>(38);
                __builder2.AddAttribute(39, "Title", "ເນື້ອໃນ");
                __builder2.AddAttribute(40, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<TblTransection, System.Object>>>(
#nullable restore
#line 26 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                    x => x.Des

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "Width", "40%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblTransection>>(44);
                __builder2.AddAttribute(45, "Title", "ໜີ້");
                __builder2.AddAttribute(46, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<TblTransection, System.Object>>>(
#nullable restore
#line 27 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                x => x.AccDebit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "Width", "4%");
                __builder2.AddAttribute(49, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTable.Align>(
#nullable restore
#line 27 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                                    Align.Right

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblTransection>>(51);
                __builder2.AddAttribute(52, "Title", "ມີ");
                __builder2.AddAttribute(53, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<TblTransection, System.Object>>>(
#nullable restore
#line 28 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                               x => x.AccCredit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "Width", "4%");
                __builder2.AddAttribute(56, "SetFooterValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                                              TotalMoneyFooterText

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTable.Align>(
#nullable restore
#line 28 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                                                                           Align.Right

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblTransection>>(59);
                __builder2.AddAttribute(60, "Title", "ວົງເງິນ");
                __builder2.AddAttribute(61, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<TblTransection, System.Object>>>(
#nullable restore
#line 29 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                    x => x.Amount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "Width", "12%");
                __builder2.AddAttribute(64, "Format", "N");
                __builder2.AddAttribute(65, "Aggregate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTable.AggregateType?>(
#nullable restore
#line 29 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                                                      AggregateType.Sum

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTable.Align>(
#nullable restore
#line 29 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                                                                                Align.Right

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblTransection>>(68);
                __builder2.AddAttribute(69, "Title", "ສະຖານະ");
                __builder2.AddAttribute(70, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<TblTransection, System.Object>>>(
#nullable restore
#line 30 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                   x => x.Status.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "Width", "4%");
                __builder2.AddAttribute(73, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTable.Align>(
#nullable restore
#line 30 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                                          Align.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblTransection>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(75, "\r\n");
#nullable restore
#line 32 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                 if (context.StatusId == 2)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(76, "                    ");
                    __builder3.OpenElement(77, "a");
                    __builder3.AddAttribute(78, "class", "btn btn-success btn-sm");
                    __builder3.AddContent(79, 
#nullable restore
#line 34 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                       context.Status.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\r\n");
#nullable restore
#line 35 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                }
                else if (context.StatusId == 3)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(81, "                    ");
                    __builder3.OpenElement(82, "a");
                    __builder3.AddAttribute(83, "class", "btn btn-danger btn-sm");
                    __builder3.AddContent(84, 
#nullable restore
#line 38 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                      context.Status.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\r\n");
#nullable restore
#line 39 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(86, "                    ");
                    __builder3.OpenElement(87, "a");
                    __builder3.AddAttribute(88, "class", "btn btn-outline-primary btn-sm");
                    __builder3.AddContent(89, 
#nullable restore
#line 42 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                               context.Status.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\r\n");
#nullable restore
#line 43 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(91, "            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblTransection>>(93);
                __builder2.AddAttribute(94, "Title", "ຜູ້ໃຊ້");
                __builder2.AddAttribute(95, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<TblTransection, System.Object>>>(
#nullable restore
#line 46 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                   x => x.User.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "Width", "4%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(98, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblTransection>>(99);
                __builder2.AddAttribute(100, "Title", "ສາຂາ");
                __builder2.AddAttribute(101, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<TblTransection, System.Object>>>(
#nullable restore
#line 48 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                 x => x.Branch.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "Width", "4%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<TblTransection>>(105);
                __builder2.AddAttribute(106, "Title", "Actions");
                __builder2.AddAttribute(107, "Width", "24%");
                __builder2.AddAttribute(108, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TblTransection>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(109, "\r\n                ");
                    __builder3.OpenElement(110, "a");
                    __builder3.AddAttribute(111, "type", "button");
                    __builder3.AddAttribute(112, "class", "btn btn-primary btn-sm");
                    __builder3.AddAttribute(113, "href", "edittran/" + (
#nullable restore
#line 51 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                context.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(114, "<i class=\"oi oi-pencil\"></i>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(115, "\r\n                ");
                    __builder3.OpenElement(116, "a");
                    __builder3.AddAttribute(117, "type", "button");
                    __builder3.AddAttribute(118, "class", "btn btn-outline-info btn-sm");
                    __builder3.AddAttribute(119, "href", "viewtran/" + (
#nullable restore
#line 52 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                     context.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(120, "<i class=\"oi oi-eye\"></i>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(121, "\r\n                ");
                    __builder3.OpenElement(122, "a");
                    __builder3.AddAttribute(123, "type", "button");
                    __builder3.AddAttribute(124, "class", "btn btn-danger btn-sm");
                    __builder3.AddAttribute(125, "href", "deletetran/" + (
#nullable restore
#line 53 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                                                 context.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(126, "<i class=\"oi oi-trash\"></i>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(127, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Pager>(129);
                __builder2.AddAttribute(130, "ShowPageNumber", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(131, "ShowTotalCount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(132, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(133, "\r\n");
#nullable restore
#line 58 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "D:\Projects\citaccount\citaccount\Pages\Transections\Indextran.razor"
       
    public int RowNumber = 1;
    public string TotalMoneyFooterText = "ລວມ:";
    List<TblTransection> tran;

    protected override void OnInitialized()
    {
        tran = tranService.ShowAllTran();
        //toastService.ShowSuccess($"ໂຫຼດຂໍ້ມູນສຳເລັດ! ປະກອບມີ {gracc.Count()} ກູ່ມບັນຊີ.", "ກູ່ມບັນຊີ");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TransectionService tranService { get; set; }
    }
}
#pragma warning restore 1591
