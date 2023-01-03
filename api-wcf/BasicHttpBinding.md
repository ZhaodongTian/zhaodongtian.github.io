<?xml version="1.0" encoding="utf-8"?><Type Name="BasicHttpBinding" FullName="CoreWCF.BasicHttpBinding">

<TypeSignature Language="C#" Value="public class BasicHttpBinding : CoreWCF.HttpBindingBase" />

<TypeSignature Language="ILAsm" Value=".class public auto ansi beforefieldinit BasicHttpBinding extends CoreWCF.HttpBindingBase" />

<TypeSignature Language="DocId" Value="T:CoreWCF.BasicHttpBinding" />

<TypeSignature Language="VB.NET" Value="Public Class BasicHttpBinding&#xA;Inherits HttpBindingBase" />

<TypeSignature Language="F#" Value="type BasicHttpBinding = class&#xA;    inherit HttpBindingBase" />

<TypeSignature Language="C++ CLI" Value="public ref class BasicHttpBinding : System::ServiceModel::HttpBindingBase" />








<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>







<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Base>


<BaseTypeName>CoreWCF.HttpBindingBase</BaseTypeName></Base>

<Interfaces>

<Interface><InterfaceName>CoreWCF.IDefaultCommunicationTimeouts</InterfaceName></Interface></Interfaces>

<Docs>

<summary>Represents a binding that a Windows Communication Foundation (WCF) service can use to configure and expose endpoints that are able to communicate with ASMX-based Web services and clients and other services that conform to the WS-I Basic Profile 1.1.</summary>

<remarks>

<format type="text/markdown"><![CDATA[

\## Remarks

The <xref:CoreWCF.BasicHttpBinding> uses HTTP as the transport for sending SOAP 1.1 messages. A service can use this binding to expose endpoints that conform to WS-I BP 1.1, such as those that ASMX clients access. Similarly, a client can use the <xref:CoreWCF.BasicHttpBinding> to communicate with services exposing endpoints that conform to WS-I BP 1.1, such as ASMX Web services or Windows Communication Foundation (WCF) services configured with the <xref:CoreWCF.BasicHttpBinding>.

Security is turned off by default, but can be added setting the <xref:CoreWCF.BasicHttpSecurityMode> to a value other than <xref:CoreWCF.BasicHttpSecurityMode.None> in the <xref:CoreWCF.BasicHttpBinding.%23ctor%28CoreWCF.BasicHttpSecurityMode%29> constructor. It uses a "Text" message encoding and UTF-8 text encoding by default.

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example shows how to configure the <xref:CoreWCF.BasicHttpBinding> in an application configuration file.

The following example shows how to programmatically configure <xref:CoreWCF.BasicHttpBinding>.

:::code language="csharp" source="~/snippets/csharp/VS\_Snippets\_CFX/s\_uebasichttpbinding/cs/service.cs" id="Snippet1":::

:::code language="vb" source="~/snippets/visualbasic/VS\_Snippets\_CFX/s\_uebasichttpbinding/vb/service.vb" id="Snippet1":::

]]>

</ExampleRemoved></Docs>

<Members>

<MemberGroup MemberName=".ctor">

<AssemblyInfo>

<AssemblyName>CoreWCF</AssemblyName>

<AssemblyVersion>2.0.5.0</AssemblyVersion>

<AssemblyVersion>4.0.0.0</AssemblyVersion>

</AssemblyInfo>

<Docs>

<summary>Initializes a new instance of the <see cref="T:CoreWCF.BasicHttpBinding" /> class.</summary>

</Docs>

</MemberGroup>

<Member MemberName=".ctor">

<MemberSignature Language="C#" Value="public BasicHttpBinding ();" />

<MemberSignature Language="ILAsm" Value=".method public hidebysig specialname rtspecialname instance void .ctor() cil managed" />

<MemberSignature Language="DocId" Value="M:CoreWCF.BasicHttpBinding.#ctor" />

<MemberSignature Language="VB.NET" Value="Public Sub New ()" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; BasicHttpBinding();" />

<MemberType>Constructor</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>







<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<Parameters />

<Docs>

<summary>Initializes a new instance of the <see cref="T:CoreWCF.BasicHttpBinding" /> class.</summary>

<remarks>

<format type="text/markdown"><![CDATA[

\## Remarks

The default value of <xref:CoreWCF.BasicHttpSecurityMode> used is <xref:CoreWCF.BasicHttpSecurityMode.None>, which specifies that the SOAP message is not secured and the client is not authenticated.

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

:::code language="csharp" source="~/snippets/csharp/VS\_Snippets\_CFX/s\_uebasichttpbinding/cs/service.cs" id="Snippet2":::

:::code language="vb" source="~/snippets/visualbasic/VS\_Snippets\_CFX/s\_uebasichttpbinding/vb/service.vb" id="Snippet2":::

]]>

</ExampleRemoved></Docs>

</Member>





<Member MemberName="CreateBindingElements">

<MemberSignature Language="C#" Value="public override CoreWCF.Channels.BindingElementCollection CreateBindingElements ();" />

<MemberSignature Language="ILAsm" Value=".method public hidebysig virtual instance class CoreWCF.Channels.BindingElementCollection CreateBindingElements() cil managed" />

<MemberSignature Language="DocId" Value="M:CoreWCF.BasicHttpBinding.CreateBindingElements" />

<MemberSignature Language="VB.NET" Value="Public Overrides Function CreateBindingElements () As BindingElementCollection" />

<MemberSignature Language="F#" Value="override this.CreateBindingElements : unit -&gt; CoreWCF.Channels.BindingElementCollection" Usage="basicHttpBinding.CreateBindingElements " />

<MemberSignature Language="C++ CLI" Value="public:&#xA; override System::ServiceModel::Channels::BindingElementCollection ^ CreateBindingElements();" />

<MemberType>Method</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>







<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<ReturnValue>

<ReturnType>CoreWCF.Channels.BindingElementCollection</ReturnType>

</ReturnValue>

<Parameters />

<Docs>

<summary>Creates and returns an ordered collection of binding elements contained in the current binding.</summary>

<returns>The <see cref="T:CoreWCF.Channels.BindingElementCollection" /> that contains the ordered stack of binding elements described by the <see cref="T:CoreWCF.BasicHttpBinding" />.</returns>

<remarks>

<format type="text/markdown"><![CDATA[

\## Remarks

The order of the binding elements is important. It reflects the order in which the protocol and transport channels are constructed and stacked. This collection of binding elements is a new collection and can be modified and then used to create a <xref:CoreWCF.Channels.CustomBinding>.

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example creates an ordered collection of the binding elements in the current binding.

:::code language="csharp" source="~/snippets/csharp/VS\_Snippets\_CFX/s\_uebasichttpbinding/cs/client.cs" id="Snippet26":::

]]>

</ExampleRemoved></Docs>

</Member>






<Member MemberName="MessageEncoding">

<MemberSignature Language="C#" Value="public CoreWCF.WSMessageEncoding MessageEncoding { get; set; }" />

<MemberSignature Language="ILAsm" Value=".property instance valuetype CoreWCF.WSMessageEncoding MessageEncoding" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.MessageEncoding" />

<MemberSignature Language="VB.NET" Value="Public Property MessageEncoding As WSMessageEncoding" />

<MemberSignature Language="F#" Value="member this.MessageEncoding : CoreWCF.WSMessageEncoding with get, set" Usage="CoreWCF.BasicHttpBinding.MessageEncoding" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property System::ServiceModel::WSMessageEncoding MessageEncoding { System::ServiceModel::WSMessageEncoding get(); void set(System::ServiceModel::WSMessageEncoding value); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>



</Attributes>

<ReturnValue>

<ReturnType>CoreWCF.WSMessageEncoding</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets or sets whether MTOM or Text is used to encode SOAP messages.</summary>

<value>The value of <see cref="T:CoreWCF.WSMessageEncoding" /> that indicates whether MTOM or Text/XML is used to encode SOAP messages. The default value is <see cref="F:CoreWCF.WSMessageEncoding.Text" />.</value>

<remarks>

<format type="text/markdown"><![CDATA[

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example sets MessageEncoding to Text.

:::code language="csharp" source="~/snippets/csharp/VS\_Snippets\_CFX/s\_uebasichttpbinding/cs/client.cs" id="Snippet19":::

The value of this property can also be set in the configuration file.

]]>

</ExampleRemoved></Docs>

</Member>



<Member MemberName="Security">

<MemberSignature Language="C#" Value="public CoreWCF.BasicHttpSecurity Security { get; set; }" />

<MemberSignature Language="ILAsm" Value=".property instance class CoreWCF.BasicHttpSecurity Security" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.Security" />

<MemberSignature Language="VB.NET" Value="Public Property Security As BasicHttpSecurity" />

<MemberSignature Language="F#" Value="member this.Security : CoreWCF.BasicHttpSecurity with get, set" Usage="CoreWCF.BasicHttpBinding.Security" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property System::ServiceModel::BasicHttpSecurity ^ Security { System::ServiceModel::BasicHttpSecurity ^ get(); void set(System::ServiceModel::BasicHttpSecurity ^ value); };" />




<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>







<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<ReturnValue>

<ReturnType>CoreWCF.BasicHttpSecurity</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets the type of security used with this binding.</summary>

<value>The <see cref="T:CoreWCF.BasicHttpSecurity" /> that is used with this binding. The default value is <see cref="F:CoreWCF.BasicHttpSecurityMode.None" />.</value>

<remarks>

<format type="text/markdown"><![CDATA[

\## Remarks

By default, the SOAP message is not secured and the client is not authenticated. To use a non-default type of security, use the <xref:CoreWCF.BasicHttpBinding.%23ctor%28CoreWCF.BasicHttpSecurityMode%29> constructor.

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example gets the `Security` property.

:::code language="csharp" source="~/snippets/csharp/VS\_Snippets\_CFX/s\_uebasichttpbinding/cs/client.cs" id="Snippet23":::

]]>

</ExampleRemoved></Docs>

</Member>








<UnmatchedMembers><Member MemberName=".ctor">

<MemberSignature Language="C#" Value="public BasicHttpBinding (CoreWCF.BasicHttpSecurityMode securityMode);" />

<MemberSignature Language="ILAsm" Value=".method public hidebysig specialname rtspecialname instance void .ctor(valuetype CoreWCF.BasicHttpSecurityMode securityMode) cil managed" />

<MemberSignature Language="DocId" Value="M:CoreWCF.BasicHttpBinding.#ctor(CoreWCF.BasicHttpSecurityMode)" />

<MemberSignature Language="VB.NET" Value="Public Sub New (securityMode As BasicHttpSecurityMode)" />

<MemberSignature Language="F#" Value="new CoreWCF.BasicHttpBinding : CoreWCF.BasicHttpSecurityMode -&gt; CoreWCF.BasicHttpBinding" Usage="new CoreWCF.BasicHttpBinding securityMode" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; BasicHttpBinding(System::ServiceModel::BasicHttpSecurityMode securityMode);" />

<MemberType>Constructor</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>







<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Parameters>

<Parameter Name="securityMode" Type="CoreWCF.BasicHttpSecurityMode" />

</Parameters>

<Docs>

<param name="securityMode">The value of <see cref="T:CoreWCF.BasicHttpSecurityMode" /> that specifies the type of security that is used with the SOAP message and for the client.</param>

<summary>Initializes a new instance of the <see cref="T:CoreWCF.BasicHttpBinding" /> class with a specified type of security used by the binding.</summary>

<remarks>

<format type="text/markdown"><![CDATA[

\## Remarks

The default value of <xref:CoreWCF.BasicHttpSecurityMode> used is <xref:CoreWCF.BasicHttpSecurityMode.None>, which specifies that the SOAP message is not secured and the client is not authenticated.

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

:::code language="csharp" source="~/snippets/csharp/VS\_Snippets\_CFX/s\_uebasichttpbinding/cs/snippets.cs" id="Snippet3":::

:::code language="vb" source="~/snippets/visualbasic/VS\_Snippets\_CFX/s\_uebasichttpbinding/vb/snippets.vb" id="Snippet3":::

]]>

</ExampleRemoved></Docs>

</Member><Member MemberName=".ctor">

<MemberSignature Language="C#" Value="public BasicHttpBinding (string configurationName);" />

<MemberSignature Language="ILAsm" Value=".method public hidebysig specialname rtspecialname instance void .ctor(string configurationName) cil managed" />

<MemberSignature Language="DocId" Value="M:CoreWCF.BasicHttpBinding.#ctor(System.String)" />

<MemberSignature Language="VB.NET" Value="Public Sub New (configurationName As String)" />

<MemberSignature Language="F#" Value="new CoreWCF.BasicHttpBinding : string -&gt; CoreWCF.BasicHttpBinding" Usage="new CoreWCF.BasicHttpBinding configurationName" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; BasicHttpBinding(System::String ^ configurationName);" />

<MemberType>Constructor</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Parameters>

<Parameter Name="configurationName" Type="System.String" Index="0" FrameworkAlternate="netframework-3.0;netframework-3.5;netframework-4.0;netframework-4.5;netframework-4.5.1;netframework-4.5.2;netframework-4.6;netframework-4.6.1;netframework-4.6.2;netframework-4.7;netframework-4.7.1;netframework-4.7.2;netframework-4.8" />

</Parameters>

<Docs>

<param name="configurationName">The binding configuration name for the <see cref="T:CoreWCF.Configuration.BasicHttpBindingElement" />.</param>

<summary>Initializes a new instance of the <see cref="T:CoreWCF.BasicHttpBinding" /> class with a binding specified by its configuration name.</summary>

<remarks>

<format type="text/markdown"><![CDATA[

]]></format>

</remarks>

<exception cref="T:System.Configuration.ConfigurationErrorsException">The binding with the configuration name <paramref name="configurationName" /> was not found.</exception>

<ExampleRemoved>

<![CDATA[

\## Examples

This example initializes a new <xref:CoreWCF.BasicHttpBinding> class with a binding specified by the configuration name `myBinding`. You must create a bindings section in the service's configuration file.

:::code language="csharp" source="~/snippets/csharp/VS\_Snippets\_CFX/s\_uebasichttpbinding/cs/snippets.cs" id="Snippet5":::

:::code language="vb" source="~/snippets/visualbasic/VS\_Snippets\_CFX/s\_uebasichttpbinding/vb/snippets.vb" id="Snippet5":::

Then the name of the binding configuration is specified in the call to the <xref:CoreWCF.BasicHttpBinding> constructor.

:::code language="csharp" source="~/snippets/csharp/VS\_Snippets\_CFX/s\_uebasichttpbinding/cs/snippets.cs" id="Snippet4":::

:::code language="vb" source="~/snippets/visualbasic/VS\_Snippets\_CFX/s\_uebasichttpbinding/vb/snippets.vb" id="Snippet4":::

]]>

</ExampleRemoved></Docs>

</Member><Member MemberName="AllowCookies">

<MemberSignature Language="C#" Value="public bool AllowCookies { get; set; }" />

<MemberSignature Language="ILAsm" Value=".property instance bool AllowCookies" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.AllowCookies" />

<MemberSignature Language="VB.NET" Value="Public Property AllowCookies As Boolean" />

<MemberSignature Language="F#" Value="member this.AllowCookies : bool with get, set" Usage="CoreWCF.BasicHttpBinding.AllowCookies" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property bool AllowCookies { bool get(); void set(bool value); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<ReturnValue>

<ReturnType>System.Boolean</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets or sets a value that indicates whether the client accepts cookies and propagates them on future requests.</summary>

<value>

<see langword="true" /> if cookies are allowed; otherwise, <see langword="false" />. The default is <see langword="false" />.</value>

<remarks>

<format type="text/markdown"><![CDATA[

\## Remarks

This property is provided as a convenience for interacting with ASMX Web services that use cookies.

When cookies are accepted by the client by setting the property to `true`, cookies returned from the server are automatically copied to all future client requests to that service.

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example sets this property to indicate that all cookies from the server should be copied to future client requests:

\```csharp

BasicHttpBinding binding = new BasicHttpBinding();

binding.AllowCookies = true;

\```

The value of this property can also be set in the configuration file.

]]>

</ExampleRemoved></Docs>

</Member><Member MemberName="BuildChannelFactory&lt;TChannel&gt;">

<MemberSignature Language="C#" Value="public override CoreWCF.Channels.IChannelFactory&lt;TChannel&gt; BuildChannelFactory&lt;TChannel&gt; (CoreWCF.Channels.BindingParameterCollection parameters);" />

<MemberSignature Language="ILAsm" Value=".method public hidebysig virtual instance class CoreWCF.Channels.IChannelFactory`1&lt;!!TChannel&gt; BuildChannelFactory&lt;TChannel&gt;(class CoreWCF.Channels.BindingParameterCollection parameters) cil managed" />

<MemberSignature Language="DocId" Value="M:CoreWCF.BasicHttpBinding.BuildChannelFactory``1(CoreWCF.Channels.BindingParameterCollection)" />

<MemberSignature Language="VB.NET" Value="Public Overrides Function BuildChannelFactory(Of TChannel) (parameters As BindingParameterCollection) As IChannelFactory(Of TChannel)" />

<MemberSignature Language="F#" Value="override this.BuildChannelFactory : CoreWCF.Channels.BindingParameterCollection -&gt; CoreWCF.Channels.IChannelFactory&lt;'Channel&gt;" Usage="basicHttpBinding.BuildChannelFactory parameters" />

<MemberSignature Language="C++ CLI" Value="public:&#xA;generic &lt;typename TChannel&gt;&#xA; override System::ServiceModel::Channels::IChannelFactory&lt;TChannel&gt; ^ BuildChannelFactory(System::ServiceModel::Channels::BindingParameterCollection ^ parameters);" />

<MemberType>Method</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>







<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<ReturnValue>

<ReturnType>CoreWCF.Channels.IChannelFactory&lt;TChannel&gt;</ReturnType>

</ReturnValue>

<TypeParameters>

<TypeParameter Name="TChannel" />

</TypeParameters>

<Parameters>

<Parameter Name="parameters" Type="CoreWCF.Channels.BindingParameterCollection" Index="0" FrameworkAlternate="dotnet-plat-ext-2.1;dotnet-plat-ext-2.2;dotnet-plat-ext-3.0;dotnet-plat-ext-3.1;dotnet-plat-ext-5.0;dotnet-plat-ext-6.0;dotnet-uwp-10.0;netcore-1.0;netcore-1.1;netframework-4.5;netframework-4.5.1;netframework-4.5.2;netframework-4.6;netframework-4.6.1;netframework-4.6.2;netframework-4.7;netframework-4.7.1;netframework-4.7.2;netframework-4.8" />

</Parameters>

<Docs>

<typeparam name="TChannel">The type of channel the channel factory produces.</typeparam>

<param name="parameters">Specifies the requirements for the channel factory built.</param>

<summary>Builds the channel factory stack on the client that creates a specified type of channel and that satisfies the features specified by a collection of binding parameters.</summary>

<returns>An <see cref="T:CoreWCF.Channels.IChannelFactory`1" /> of type <paramref name="TChannel" /> that satisfies the features specified by the collection.</returns>

<remarks>To be added.</remarks>

</Docs>

</Member><Member MemberName="BypassProxyOnLocal">

<MemberSignature Language="C#" Value="public bool BypassProxyOnLocal { get; set; }" />

<MemberSignature Language="ILAsm" Value=".property instance bool BypassProxyOnLocal" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.BypassProxyOnLocal" />

<MemberSignature Language="VB.NET" Value="Public Property BypassProxyOnLocal As Boolean" />

<MemberSignature Language="F#" Value="member this.BypassProxyOnLocal : bool with get, set" Usage="CoreWCF.BasicHttpBinding.BypassProxyOnLocal" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property bool BypassProxyOnLocal { bool get(); void set(bool value); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<ReturnValue>

<ReturnType>System.Boolean</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets or sets a value that indicates whether to bypass the proxy server for local addresses.</summary>

<value>

<see langword="true" /> to bypass the proxy server for local addresses; otherwise, <see langword="false" />. The default value is <see langword="false" />.</value>

<remarks>

<format type="text/markdown"><![CDATA[

\## Remarks

An Internet resource is local if it has a local address. A local address is one that is on same computer, the local LAN or intranet and is identified, syntactically, by the lack of a period (\.) as in the URIs `http://webserver/` and `http://localhost/`.

Setting the BypassProxyOnLocal property determines whether endpoints configured with the <xref:CoreWCF.BasicHttpBinding> use the proxy server when accessing local resources.

If BypassProxyOnLocal is `true`, requests to local Internet resources do not use the proxy server. Use the host name (rather than `localhost`) if you want clients to go through a proxy when talking to services on the same machine when this property is set to `true`.

When BypassProxyOnLocal is `false`, all Internet requests to non-localhost URIs are made through the proxy server. Requests to URIs with localhost will not use the proxy server regardless of the BypassProxyOnLocal setting.

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example sets this property to indicate that the proxy should be bypassed for local resources.

\```csharp

BasicHttpBinding binding = new BasicHttpBinding();

binding.BypassProxyOnLocal = true;

\```

The value of this property can also be set in the configuration file.

\```xml

<configuration>

<system.serviceModel>

<bindings>

<basicHttpBinding>

<binding name="Binding1"

bypassProxyOnLocal="true">

<security mode="None" />

</binding>

</basicHttpBinding>

</bindings>

</system.serviceModel>

</configuration>

\```

]]>

</ExampleRemoved></Docs>

</Member><Member MemberName="EnableHttpCookieContainer">

<MemberSignature Language="C#" Value="public bool EnableHttpCookieContainer { get; set; }" />

<MemberSignature Language="ILAsm" Value=".property instance bool EnableHttpCookieContainer" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.EnableHttpCookieContainer" />

<MemberSignature Language="VB.NET" Value="Public Property EnableHttpCookieContainer As Boolean" />

<MemberSignature Language="F#" Value="member this.EnableHttpCookieContainer : bool with get, set" Usage="CoreWCF.BasicHttpBinding.EnableHttpCookieContainer" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property bool EnableHttpCookieContainer { bool get(); void set(bool value); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>


</Attributes>

<ReturnValue>

<ReturnType>System.Boolean</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets or sets a value that indicates whether HTTP cookie container is enabled.</summary>

<value>

<see langword="true" /> if HTTP cookie container is enabled; otherwise, <see langword="false" />.</value>

<remarks>To be added.</remarks>

</Docs>

</Member><Member MemberName="EnvelopeVersion">

<MemberSignature Language="C#" Value="public CoreWCF.EnvelopeVersion EnvelopeVersion { get; }" />

<MemberSignature Language="ILAsm" Value=".property instance class CoreWCF.EnvelopeVersion EnvelopeVersion" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.EnvelopeVersion" />

<MemberSignature Language="VB.NET" Value="Public ReadOnly Property EnvelopeVersion As EnvelopeVersion" />

<MemberSignature Language="F#" Value="member this.EnvelopeVersion : CoreWCF.EnvelopeVersion" Usage="CoreWCF.BasicHttpBinding.EnvelopeVersion" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property System::ServiceModel::EnvelopeVersion ^ EnvelopeVersion { System::ServiceModel::EnvelopeVersion ^ get(); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<ReturnValue>

<ReturnType>CoreWCF.EnvelopeVersion</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets the version of SOAP that is used for messages that are processed by this binding.</summary>

<value>The value of the <see cref="T:CoreWCF.EnvelopeVersion" /> that is used with this binding. The value is always SOAP 1.1.</value>

<remarks>

<format type="text/markdown"><![CDATA[

\## Remarks

SOAP 1.1 is the only value that can be used with this binding.

]]></format>

</remarks>

</Docs>

</Member><Member MemberName="HostNameComparisonMode">

<MemberSignature Language="C#" Value="public CoreWCF.HostNameComparisonMode HostNameComparisonMode { get; set; }" />

<MemberSignature Language="ILAsm" Value=".property instance valuetype CoreWCF.HostNameComparisonMode HostNameComparisonMode" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.HostNameComparisonMode" />

<MemberSignature Language="VB.NET" Value="Public Property HostNameComparisonMode As HostNameComparisonMode" />

<MemberSignature Language="F#" Value="member this.HostNameComparisonMode : CoreWCF.HostNameComparisonMode with get, set" Usage="CoreWCF.BasicHttpBinding.HostNameComparisonMode" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property System::ServiceModel::HostNameComparisonMode HostNameComparisonMode { System::ServiceModel::HostNameComparisonMode get(); void set(System::ServiceModel::HostNameComparisonMode value); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<ReturnValue>

<ReturnType>CoreWCF.HostNameComparisonMode</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets or sets a value that indicates whether the hostname is used to reach the service when matching the URI.</summary>

<value>The <see cref="T:CoreWCF.HostNameComparisonMode" /> value that indicates whether the hostname is used to reach the service when matching on the URI. The default value is <see cref="F:CoreWCF.HostNameComparisonMode.StrongWildcard" />, which ignores the hostname in the match.</value>

<remarks>

<format type="text/markdown"><![CDATA[

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example sets this property to indicate that an exact match is required.

\```csharp

BasicHttpBinding binding = new BasicHttpBinding();

binding.HostNameComparisonMode = HostNameComparisonMode.Exact;

\```

The value of this property can also be set in the configuration file.

\```xml

<configuration>

<system.serviceModel>

<bindings>

<basicHttpBinding>

<binding name="Binding1"

hostNameComparisonMode ="Exact">

<security mode="None" />

</binding>

</basicHttpBinding>

</bindings>

</system.serviceModel>

</configuration>

\```

]]>

</ExampleRemoved></Docs>

</Member><Member MemberName="MaxBufferPoolSize">

<MemberSignature Language="C#" Value="public long MaxBufferPoolSize { get; set; }" />

<MemberSignature Language="ILAsm" Value=".property instance int64 MaxBufferPoolSize" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.MaxBufferPoolSize" />

<MemberSignature Language="VB.NET" Value="Public Property MaxBufferPoolSize As Long" />

<MemberSignature Language="F#" Value="member this.MaxBufferPoolSize : int64 with get, set" Usage="CoreWCF.BasicHttpBinding.MaxBufferPoolSize" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property long MaxBufferPoolSize { long get(); void set(long value); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<ReturnValue>

<ReturnType>System.Int64</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets or sets the maximum amount of memory, in bytes,  that is allocated for use by the manager of the message buffers that receive messages from the channel.</summary>

<value>The maximum amount of memory, in bytes, available for use by the message buffer manager. The default value is 524288 (0x80000) bytes.</value>

<remarks>

<format type="text/markdown"><![CDATA[

\## Remarks

The <xref:CoreWCF.Channels.BufferManager> minimizes the cost of using buffers by using a buffer pool.

Buffers are required to process messages by the service when they come out of the channel.

If there is not sufficient memory in the buffer pool to process the message load, the <xref:CoreWCF.Channels.BufferManager> must allocate additional memory from the CLR heap, which increases the garbage collection overhead.

Extensive allocation from the CLR garbage heap is an indication that the buffer pool size is too small and that performance can be improved with a larger allocation by increasing the MaxBufferPoolSize limit.

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example sets this property to twice the default value.

\```csharp

BasicHttpBinding binding = new BasicHttpBinding();

// Use double the default value

binding.MaxBufferPoolSize = 0x80000 \* 2;

\```

The value of this property can also be set in the configuration file.

\```xml

<configuration>

<system.serviceModel>

<bindings>

<basicHttpBinding>

<binding name="Binding1">

<!-- set pool size to double default of 0x80000 -->

maxBufferPoolSize = 0x100000

<security mode="None" />

</binding>

</basicHttpBinding>

</bindings>

</system.serviceModel>

</configuration>

\```

]]>

</ExampleRemoved></Docs>

</Member><Member MemberName="MaxBufferSize">

<MemberSignature Language="C#" Value="public int MaxBufferSize { get; set; }" />

<MemberSignature Language="ILAsm" Value=".property instance int32 MaxBufferSize" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.MaxBufferSize" />

<MemberSignature Language="VB.NET" Value="Public Property MaxBufferSize As Integer" />

<MemberSignature Language="F#" Value="member this.MaxBufferSize : int with get, set" Usage="CoreWCF.BasicHttpBinding.MaxBufferSize" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property int MaxBufferSize { int get(); void set(int value); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<ReturnValue>

<ReturnType>System.Int32</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets or sets the maximum size, in bytes, for a buffer that receives messages from the channel.</summary>

<value>The maximum size, in bytes, of a buffer that stores messages while they are processed for an endpoint configured with this binding. The default value is 65,536 bytes.</value>

<remarks>

<format type="text/markdown"><![CDATA[

\## Remarks

If there is not sufficient memory in the buffer to store the message while it is processed, more memory must be allocated from the CLR heap, which increases the garbage collection overhead.

Extensive allocation from the CLR garbage heap is an indication that the message buffer size is too small and that performance can be improved with a larger allocation.

The value of the MaxBufferSize property and its significance is different depending on whether the messages are being buffered or streamed on the channel through which they are being received:

- For buffered transports (<xref:CoreWCF.BasicHttpBinding.TransferMode> set to <xref:CoreWCF.TransferMode.Buffered?displayProperty=nameWithType>), this value is always equal to that specified by the <xref:CoreWCF.BasicHttpBinding.MaxReceivedMessageSize> property.

- For streamed transports (<xref:CoreWCF.BasicHttpBinding.TransferMode> set to <xref:CoreWCF.TransferMode.Streamed?displayProperty=nameWithType>), only the SOAP headers must be buffered to generate the message.

The body can be streamed in on-demand. In this case, MaxBufferSize is less than or equal to <xref:CoreWCF.BasicHttpBinding.MaxReceivedMessageSize>, where <xref:CoreWCF.BasicHttpBinding.MaxReceivedMessageSize> bounds the size of the overall message (headers and body) and MaxBufferSize bounds only the size of the SOAP headers.

The limitations on buffer size set here are for optimizing the performance of message exchanges.

If a message exceeds the maximum value set for the buffer, it is not dropped.

Instead, more memory is requested from the CLR heap and this incurs more garbage collection overhead than using the buffers.

\> [!NOTE]

\> The settings for MaxBufferSize and MaxReceivedMessageSize, are local behavioral settings.

\> This means that they are not transmitted to other endpoints in metadata.

\> If you generate a proxy to a service with a maximum message size of 2GB from metadata, the proxy still has a default value of 64K.

\> This leaves control of the appropriate bounds for message and message buffer size in the scope of local administrators.

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example sets \*\*MaxBufferSize\*\* to 1,000,000 bytes.

\```csharp

BasicHttpBinding binding = new BasicHttpBinding();



// set to one million

binding.MaxBufferSize = 1000000;

\```

The value of this property can also be set in the configuration file.

]]>

</ExampleRemoved></Docs>

</Member><Member MemberName="MaxReceivedMessageSize">

<MemberSignature Language="C#" Value="public long MaxReceivedMessageSize { get; set; }" />

<MemberSignature Language="ILAsm" Value=".property instance int64 MaxReceivedMessageSize" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.MaxReceivedMessageSize" />

<MemberSignature Language="VB.NET" Value="Public Property MaxReceivedMessageSize As Long" />

<MemberSignature Language="F#" Value="member this.MaxReceivedMessageSize : int64 with get, set" Usage="CoreWCF.BasicHttpBinding.MaxReceivedMessageSize" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property long MaxReceivedMessageSize { long get(); void set(long value); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<ReturnValue>

<ReturnType>System.Int64</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets or sets the maximum size, in bytes, for a message that can be received on a channel configured with this binding.</summary>

<value>The maximum size, in bytes, for a message that is processed by the binding. The default value is 65,536 bytes.</value>

<remarks>

<format type="text/markdown"><![CDATA[

\## Remarks

The size of the messages that can be received on the wire by services using the BasicHttpBinding is bounded by the amount of memory allocated for each message.

This bound on message size is intended to limit exposure to DoS-style attacks.

There is also a <xref:CoreWCF.BasicHttpBinding.MaxBufferSize> property on the <xref:CoreWCF.BasicHttpBinding>:

For buffered transports, (<xref:CoreWCF.BasicHttpBinding.TransferMode> set to <xref:CoreWCF.TransferMode.Buffered>).

This value is always equal to that specified by the MaxReceivedMessageSize.

For streamed transports (<xref:CoreWCF.BasicHttpBinding.TransferMode> set to <xref:CoreWCF.TransferMode.Streamed>), only the SOAP headers must be buffered to generate the message.

The body can be streamed in on-demand. In this case, <xref:CoreWCF.BasicHttpBinding.MaxBufferSize> is less than or equal to MaxReceivedMessageSize,

where MaxReceivedMessageSize bounds the size of the overall message (headers and body) and <xref:CoreWCF.BasicHttpBinding.MaxBufferSize> bounds the size of the SOAP headers.

]]></format>

</remarks>

<exception cref="T:System.ArgumentOutOfRangeException">The value is less than zero.</exception>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example sets MaxReceivedMessageSize to 1,000,000 bytes.

\```csharp

BasicHttpBinding binding = new BasicHttpBinding();

// Use double the default value

binding.MaxReceivedMessageSize = 65536 \* 2;

\```

The value of this property can also be set in the configuration file.

\```xml

<configuration>

<system.serviceModel>

<bindings>

<basicHttpBinding>

<binding name="Binding1"

maxReceivedMessageSize = "1000000">

<security mode="None" />

</binding>

</basicHttpBinding>

</bindings>

</system.serviceModel>

</configuration>

\```

]]>

</ExampleRemoved></Docs>

</Member><Member MemberName="ProxyAddress">

<MemberSignature Language="C#" Value="public Uri ProxyAddress { get; set; }" />

<MemberSignature Language="ILAsm" Value=".property instance class System.Uri ProxyAddress" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.ProxyAddress" />

<MemberSignature Language="VB.NET" Value="Public Property ProxyAddress As Uri" />

<MemberSignature Language="F#" Value="member this.ProxyAddress : Uri with get, set" Usage="CoreWCF.BasicHttpBinding.ProxyAddress" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property Uri ^ ProxyAddress { Uri ^ get(); void set(Uri ^ value); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>


</Attributes>

<ReturnValue>

<ReturnType>System.Uri</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets or sets the URI address of the HTTP proxy.</summary>

<value>A <see cref="T:System.Uri" /> that serves as the address of the HTTP proxy. The default value is null.</value>

<remarks>

<format type="text/markdown"><![CDATA[

\## Remarks

If the <xref:CoreWCF.BasicHttpBinding.UseDefaultWebProxy> is set to `true`, the default address is used and the value of the ProxyAddress set is ignored.

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example sets ProxyAddress to application settings.

\```csharp

// Get base address from app settings in configuration

Uri baseAddress = new Uri(ConfigurationManager.AppSettings["baseAddress"]);

BasicHttpBinding binding = new BasicHttpBinding();

binding.ProxyAddress = baseAddress;

\```

The value of this property can also be set in the configuration file.

\```xml

<configuration>

<system.serviceModel>

<bindings>

<basicHttpBinding>

<binding name="Binding1"

proxyAddress = "http://myProxy">

<security mode="None" />

</binding>

</basicHttpBinding>

</bindings>

</system.serviceModel>

</configuration>

\```

]]>

</ExampleRemoved></Docs>

</Member><Member MemberName="ReaderQuotas">

<MemberSignature Language="C#" Value="public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get; set; }" />

<MemberSignature Language="ILAsm" Value=".property instance class System.Xml.XmlDictionaryReaderQuotas ReaderQuotas" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.ReaderQuotas" />

<MemberSignature Language="VB.NET" Value="Public Property ReaderQuotas As XmlDictionaryReaderQuotas" />

<MemberSignature Language="F#" Value="member this.ReaderQuotas : System.Xml.XmlDictionaryReaderQuotas with get, set" Usage="CoreWCF.BasicHttpBinding.ReaderQuotas" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property System::Xml::XmlDictionaryReaderQuotas ^ ReaderQuotas { System::Xml::XmlDictionaryReaderQuotas ^ get(); void set(System::Xml::XmlDictionaryReaderQuotas ^ value); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<ReturnValue>

<ReturnType>System.Xml.XmlDictionaryReaderQuotas</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets or sets constraints on the complexity of SOAP messages that can be processed by endpoints configured with this binding.</summary>

<value>The <see cref="T:System.Xml.XmlDictionaryReaderQuotas" /> that specifies the complexity constraints.</value>

<remarks>

<format type="text/markdown"><![CDATA[

\## Remarks

The complexity constraints provide protection from denial of service (DOS) attacks that attempt to use message complexity to tie up endpoint processing resources.

Other complexity constraints include items such as a maximum element depth and a maximum length for string content within the message.

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example sets ReaderQuotas to application settings.

\```csharp

BasicHttpBinding binding = new BasicHttpBinding();

XmlDictionaryReaderQuotas readerQuotas = new XmlDictionaryReaderQuotas();

readerQuotas.MaxArrayLength = 25 \* 1024;



binding.ReaderQuotas = readerQuotas;

\```

The value of this property can also be set in the configuration file.

\```xml

<configuration>

<system.serviceModel>

<bindings>

<basicHttpBinding>

<binding name="Binding1">

<readerQuotas maxBytesPerRead ="1000"

maxDepth="100"/>

<security mode="None" />

</binding>

</basicHttpBinding>

</bindings>

</system.serviceModel>

</configuration>

\```

]]>

</ExampleRemoved></Docs>

</Member><Member MemberName="Scheme">

<MemberSignature Language="C#" Value="public override string Scheme { get; }" />

<MemberSignature Language="ILAsm" Value=".property instance string Scheme" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.Scheme" />

<MemberSignature Language="VB.NET" Value="Public Overrides ReadOnly Property Scheme As String" />

<MemberSignature Language="F#" Value="member this.Scheme : string" Usage="CoreWCF.BasicHttpBinding.Scheme" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; virtual property System::String ^ Scheme { System::String ^ get(); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<ReturnValue>

<ReturnType>System.String</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets the URI transport scheme for the channels and listeners that are configured with this binding.</summary>

<value>"https" if the security mode in the transport binding element is set to <see cref="F:CoreWCF.BasicHttpSecurityMode.Transport" /> or <see cref="F:CoreWCF.BasicHttpSecurityMode.TransportWithMessageCredential" />; "http" otherwise.</value>

<remarks>

<format type="text/markdown"><![CDATA[

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example gets the current Scheme.

\```csharp

BasicHttpBinding binding = new BasicHttpBinding();

string thisScheme = binding.Scheme;

\```

]]>

</ExampleRemoved></Docs>

</Member><Member MemberName="ShouldSerializeEnableHttpCookieContainer">

<MemberSignature Language="C#" Value="public bool ShouldSerializeEnableHttpCookieContainer ();" />

<MemberSignature Language="ILAsm" Value=".method public hidebysig instance bool ShouldSerializeEnableHttpCookieContainer() cil managed" />

<MemberSignature Language="DocId" Value="M:CoreWCF.BasicHttpBinding.ShouldSerializeEnableHttpCookieContainer" />

<MemberSignature Language="VB.NET" Value="Public Function ShouldSerializeEnableHttpCookieContainer () As Boolean" />

<MemberSignature Language="F#" Value="member this.ShouldSerializeEnableHttpCookieContainer : unit -&gt; bool" Usage="basicHttpBinding.ShouldSerializeEnableHttpCookieContainer " />

<MemberSignature Language="C++ CLI" Value="public:&#xA; bool ShouldSerializeEnableHttpCookieContainer();" />

<MemberType>Method</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<ReturnValue>

<ReturnType>System.Boolean</ReturnType>

</ReturnValue>

<Parameters />

<Docs>

<summary>Indicates whether the http cookie container should enable the serialization.</summary>

<returns>

<see langword="true" /> if the http cookie container should enable the serialization; otherwise, <see langword="false" />.</returns>

<remarks>To be added.</remarks>

</Docs>

</Member><Member MemberName="ShouldSerializeReaderQuotas">

<MemberSignature Language="C#" Value="public bool ShouldSerializeReaderQuotas ();" />

<MemberSignature Language="ILAsm" Value=".method public hidebysig instance bool ShouldSerializeReaderQuotas() cil managed" />

<MemberSignature Language="DocId" Value="M:CoreWCF.BasicHttpBinding.ShouldSerializeReaderQuotas" />

<MemberSignature Language="VB.NET" Value="Public Function ShouldSerializeReaderQuotas () As Boolean" />

<MemberSignature Language="F#" Value="member this.ShouldSerializeReaderQuotas : unit -&gt; bool" Usage="basicHttpBinding.ShouldSerializeReaderQuotas " />

<MemberSignature Language="C++ CLI" Value="public:&#xA; bool ShouldSerializeReaderQuotas();" />

<MemberType>Method</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<ReturnValue>

<ReturnType>System.Boolean</ReturnType>

</ReturnValue>

<Parameters />

<Docs>

<summary>Returns whether the constraint values placed on the complexity of SOAP message structure should be serialized.</summary>

<returns>

<see langword="true" /> if reader quotas should be serialized; otherwise, <see langword="false" />.</returns>

<remarks>To be added.</remarks>

</Docs>

</Member><Member MemberName="ShouldSerializeSecurity">

<MemberSignature Language="C#" Value="public bool ShouldSerializeSecurity ();" />

<MemberSignature Language="ILAsm" Value=".method public hidebysig instance bool ShouldSerializeSecurity() cil managed" />

<MemberSignature Language="DocId" Value="M:CoreWCF.BasicHttpBinding.ShouldSerializeSecurity" />

<MemberSignature Language="VB.NET" Value="Public Function ShouldSerializeSecurity () As Boolean" />

<MemberSignature Language="F#" Value="member this.ShouldSerializeSecurity : unit -&gt; bool" Usage="basicHttpBinding.ShouldSerializeSecurity " />

<MemberSignature Language="C++ CLI" Value="public:&#xA; bool ShouldSerializeSecurity();" />

<MemberType>Method</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<ReturnValue>

<ReturnType>System.Boolean</ReturnType>

</ReturnValue>

<Parameters />

<Docs>

<summary>Returns whether security settings should be serialized based upon whether serialization already occurs, for example at the message or transport level.</summary>

<returns>

<see langword="true" /> if security should be serialized; otherwise, <see langword="false" />.</returns>

<remarks>To be added.</remarks>

</Docs>

</Member><Member MemberName="ShouldSerializeTextEncoding">

<MemberSignature Language="C#" Value="public bool ShouldSerializeTextEncoding ();" />

<MemberSignature Language="ILAsm" Value=".method public hidebysig instance bool ShouldSerializeTextEncoding() cil managed" />

<MemberSignature Language="DocId" Value="M:CoreWCF.BasicHttpBinding.ShouldSerializeTextEncoding" />

<MemberSignature Language="VB.NET" Value="Public Function ShouldSerializeTextEncoding () As Boolean" />

<MemberSignature Language="F#" Value="member this.ShouldSerializeTextEncoding : unit -&gt; bool" Usage="basicHttpBinding.ShouldSerializeTextEncoding " />

<MemberSignature Language="C++ CLI" Value="public:&#xA; bool ShouldSerializeTextEncoding();" />

<MemberType>Method</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<ReturnValue>

<ReturnType>System.Boolean</ReturnType>

</ReturnValue>

<Parameters />

<Docs>

<summary>Returns whether settings for text encoding should be serialized.</summary>

<returns>

<see langword="true" /> if text encoding should be serialized; otherwise, <see langword="false" />.</returns>

<remarks>To be added.</remarks>

</Docs>

</Member><Member MemberName="CoreWCF.Channels.IBindingRuntimePreferences.ReceiveSynchronously">

<MemberSignature Language="C#" Value="bool CoreWCF.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get; }" />

<MemberSignature Language="ILAsm" Value=".property instance bool CoreWCF.Channels.IBindingRuntimePreferences.ReceiveSynchronously" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.System#ServiceModel#Channels#IBindingRuntimePreferences#ReceiveSynchronously" />

<MemberSignature Language="VB.NET" Value=" ReadOnly Property ReceiveSynchronously As Boolean Implements IBindingRuntimePreferences.ReceiveSynchronously" />

<MemberSignature Language="F#" Value="member this.CoreWCF.Channels.IBindingRuntimePreferences.ReceiveSynchronously : bool" Usage="CoreWCF.Channels.IBindingRuntimePreferences.ReceiveSynchronously" />

<MemberSignature Language="C++ CLI" Value="property bool System::ServiceModel::Channels::IBindingRuntimePreferences::ReceiveSynchronously { bool get(); };" />

<MemberType>Property</MemberType>

<Implements>

<InterfaceMember>P:CoreWCF.Channels.IBindingRuntimePreferences.ReceiveSynchronously</InterfaceMember>

</Implements>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<ReturnValue>

<ReturnType>System.Boolean</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets a value that indicates whether incoming requests are handled synchronously or asynchronously.</summary>

<value>Always <see langword="false" />.</value>

<remarks>

<format type="text/markdown"><![CDATA[

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

This example gets the ReceiveSynchronously value.

\```csharp

BasicHttpBinding binding = new BasicHttpBinding();

IBindingRuntimePreferences s = (binding as IBindingRuntimePreferences);

bool receiveSynchronously = s.ReceiveSynchronously;

\```

]]>

</ExampleRemoved></Docs>

</Member><Member MemberName="TextEncoding">

<MemberSignature Language="C#" Value="public System.Text.Encoding TextEncoding { get; set; }" />

<MemberSignature Language="ILAsm" Value=".property instance class System.Text.Encoding TextEncoding" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.TextEncoding" />

<MemberSignature Language="VB.NET" Value="Public Property TextEncoding As Encoding" />

<MemberSignature Language="F#" Value="member this.TextEncoding : System.Text.Encoding with get, set" Usage="CoreWCF.BasicHttpBinding.TextEncoding" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property System::Text::Encoding ^ TextEncoding { System::Text::Encoding ^ get(); void set(System::Text::Encoding ^ value); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<ReturnValue>

<ReturnType>System.Text.Encoding</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets or sets the character encoding that is used for the message text.</summary>

<value>The <see cref="T:System.Text.Encoding" /> that indicates the character encoding that is used. The default is <see cref="T:System.Text.UTF8Encoding" />.</value>

<remarks>

<format type="text/markdown"><![CDATA[

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example sets TextEncoding to <xref:System.Text.Encoding.Unicode?displayProperty=nameWithType>.

\```csharp

BasicHttpBinding binding = new BasicHttpBinding();

binding.TextEncoding = System.Text.Encoding.Unicode;

\```

The value of this property can also be set in the configuration file.

\```xml

<configuration>

<system.serviceModel>

<bindings>

<basicHttpBinding>

<binding name="Binding1"

textEncoding = "UnicodeFffeTextEncoding">

<security mode="None" />

</binding>

</basicHttpBinding>

</bindings>

</system.serviceModel>

</configuration>

\```

]]>

</ExampleRemoved></Docs>

</Member><Member MemberName="TransferMode">

<MemberSignature Language="C#" Value="public CoreWCF.TransferMode TransferMode { get; set; }" />

<MemberSignature Language="ILAsm" Value=".property instance valuetype CoreWCF.TransferMode TransferMode" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.TransferMode" />

<MemberSignature Language="VB.NET" Value="Public Property TransferMode As TransferMode" />

<MemberSignature Language="F#" Value="member this.TransferMode : CoreWCF.TransferMode with get, set" Usage="CoreWCF.BasicHttpBinding.TransferMode" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property System::ServiceModel::TransferMode TransferMode { System::ServiceModel::TransferMode get(); void set(System::ServiceModel::TransferMode value); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<ReturnValue>

<ReturnType>CoreWCF.TransferMode</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets or sets a value that indicates whether messages are sent buffered or streamed.</summary>

<value>The <see cref="T:CoreWCF.TransferMode" /> that indicates whether messages are sent buffered or streamed.</value>

<remarks>

<format type="text/markdown"><![CDATA[

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

The following example sets TransferMode to <xref:CoreWCF.TransferMode.Streamed>.

\```csharp

BasicHttpBinding binding = new BasicHttpBinding();

binding.TransferMode = TransferMode.Streamed;

\```

The value of this property can also be set in the configuration file.

]]>

</ExampleRemoved></Docs>

</Member><Member MemberName="UseDefaultWebProxy">

<MemberSignature Language="C#" Value="public bool UseDefaultWebProxy { get; set; }" />

<MemberSignature Language="ILAsm" Value=".property instance bool UseDefaultWebProxy" />

<MemberSignature Language="DocId" Value="P:CoreWCF.BasicHttpBinding.UseDefaultWebProxy" />

<MemberSignature Language="VB.NET" Value="Public Property UseDefaultWebProxy As Boolean" />

<MemberSignature Language="F#" Value="member this.UseDefaultWebProxy : bool with get, set" Usage="CoreWCF.BasicHttpBinding.UseDefaultWebProxy" />

<MemberSignature Language="C++ CLI" Value="public:&#xA; property bool UseDefaultWebProxy { bool get(); void set(bool value); };" />

<MemberType>Property</MemberType>

<AssemblyInfo>

<AssemblyName>CoreWCF.Http</AssemblyName>

<AssemblyVersion>1.0</AssemblyVersion></AssemblyInfo>

<Attributes>

</Attributes>

<ReturnValue>

<ReturnType>System.Boolean</ReturnType>

</ReturnValue>

<Docs>

<summary>Gets or sets a value that indicates whether the auto-configured HTTP proxy of the system should be used, if available.</summary>

<value>

<see langword="true" /> if the auto-configured HTTP proxy of the system should be used, if available; otherwise, <see langword="false" />. The default value is <see langword="true" />.</value>

<remarks>

<format type="text/markdown"><![CDATA[

\## Remarks

It is an error for this to be `true` and <xref:CoreWCF.BasicHttpBinding.ProxyAddress> to be non-null.

]]></format>

</remarks>

<ExampleRemoved>

<![CDATA[

\## Examples

This example sets the value of UseDefaultWebProxy to `false`.

\```csharp

BasicHttpBinding binding = new BasicHttpBinding();

binding.UseDefaultWebProxy = false;

\```

The value of this property can also be set in the configuration file.

]]>

</ExampleRemoved></Docs>

</Member></UnmatchedMembers></Members>

</Type>
