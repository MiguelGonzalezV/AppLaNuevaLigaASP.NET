<%@ Page Language="C#" MasterPageFile="~/Web/Plantilla.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="App.Web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="well text-justify">
            <p>
                Una	empresa	local	de	video	juegos	llamada	<strong>“La	Nueva	Liga”</strong>	a	empezado	a	desarrollar	
                un	nuevo	proyecto	en	el	cual	desean	ser	un	pocos	mas	competitivos	e	innovadores	al	
                momento	 de	 crear	 los	 personajes	 que	 van	 interactuar	 en	 un nuevo	 juego,	 por	 tal	
                motivo	ha	propuesta	una	nueva estructura	y	categorización	de	los	personajes	la	cual	
                es	 la	 siguiente;	 Hay	 una	 clase	 padre	 llamada	<strong> Personajes</strong> y	 tendrá	 las	 siguientes	
                subclases	 <strong>Humanos</strong>	 <strong>SuperHumanos</strong>,	 <strong>Artificiales</strong> y	<strong> Alíens</strong>,	 pero	 requieren	 de	 sus	
                habilidades	 para	 identificar	 cuales	 son	 las	 característica	 mas	 relevantes	 que	
                diferencien	a	cada	uno	de	los	personajes, recuerde	identificar	métodos	abstractos	que	
                se	 puedan	 sobre	 escribir	 en	las	 subclase,	 para	 se	 un	mas	 dinámicos	 al	momento	 de	
                crear	a	los	diferentes personajes,	también se	propone	un	interface	llamada	IFicha la	
                cuales	tendrá	los	siguientes	métodos:
            </p>
            <ul>
                <li><strong>Add</strong>:	Este	método	recibirá	por	parámetro	un	tipo	de	caracterización.</li>
                <li><strong>Liga</strong>:	Es	un	método	que	adiciona	a	la	liga	o	grupo	que	pertenece	el	personaje.</li>
                <li><strong>Enemigo</strong>:	 es	 un	 método que	 adiciona	 un	 personaje	 	 el	 cual	 es	 el	 enemigo	 de	 dicho	
                personaje	creado.</li>
            </ul>
                <strong>Caracterización</strong> es	 una	 clase	 abstracta	 que	 tiene	 como	 subclases	 de	 Poderes,	
                Habilidades,	Debilidades,	Armas,	Personalidad.
        </div>
    </div>
</asp:Content>
