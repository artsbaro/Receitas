â
<C:\Projetos\Receitas\src\DevWebReceitas.Infra.Data\Anchor.cs
	namespace 	
DevWebReceitas
 
. 
Infra 
. 
Data #
{ 
public 

class 
Anchor 
{ 
public 
Anchor 
( 
) 
{ 	
} 	
}		 
}

 ÿ1
TC:\Projetos\Receitas\src\DevWebReceitas.Infra.Data\Repository\CategoriaRepository.cs
	namespace 	
DevWebReceitas
 
. 
Infra 
. 
Data #
.# $

Repository$ .
{ 
public 

class 
CategoriaRepository $
:% &
RepositoryBase' 5
,5 6 
ICategoriaRepository7 K
{ 
public 
CategoriaRepository "
(" #
IConfiguration# 1
configuration2 ?
)? @
:A B
baseC G
(G H
configurationH U
)U V
{ 	
} 	
public 
void 
Create 
( 
	Categoria $
entity% +
)+ ,
{ 	

Connection 
. 
Execute 
( 
$str (
,( )
commandType 
: 
CommandType (
.( )
StoredProcedure) 8
,8 9
param 
: 
new 
{ 
entity 
. 
Codigo !
,! "
entity 
. 
Titulo !
,! "
entity 
. 
	Descricao $
,$ %
entity 
. 
Ativo  
,  !
entity 
. 
DataCadastro '
} 
)   
;   
}!! 	
public$$ 
async$$ 
Task$$ 
<$$ 
	Categoria$$ #
>$$# $
FindById$$% -
($$- .
short$$. 3
id$$4 6
)$$6 7
{%% 	
return&& 
await&& 

Connection&& #
.&&# $$
QueryFirstOrDefaultAsync&&$ <
<&&< =
	Categoria&&= F
>&&F G
(&&G H
$str'' (
,''( )
commandType(( 
:(( 
CommandType(( '
.((' (
StoredProcedure((( 7
,((7 8
param)) 
:)) 
new)) 
{** 
Id++ 
=++ 
id++ 
},, 
)-- 
;-- 
}.. 	
public00 
async00 
Task00 
<00 
	Categoria00 #
>00# $

FindByCode00% /
(00/ 0
Guid000 4
codigo005 ;
)00; <
{11 	
return22 
await22 

Connection22 #
.22# $$
QueryFirstOrDefaultAsync22$ <
<22< =
	Categoria22= F
>22F G
(22G H
$str33 *
,33* +
commandType44 
:44 
CommandType44 '
.44' (
StoredProcedure44( 7
,447 8
param55 
:55 
new55 
{66 
Codigo77 
=77 
codigo77 #
}88 
)99 
;99 
}:: 	
public<< 
IEnumerable<< 
<<< 
	Categoria<< $
><<$ %
List<<& *
(<<* +
CategoriaFilter<<+ :
filter<<; A
)<<A B
{== 	
return>> 

Connection>> 
.>> 
Query>> #
<>># $
	Categoria>>$ -
>>>- .
(>>. /
$str?? ,
,??, -
commandType@@ 
:@@ 
CommandType@@ '
.@@' (
StoredProcedure@@( 7
,@@7 8
paramAA 
:AA 
newAA 
{BB 
filterCC 
.CC 
TituloCC !
,CC! "
filterDD 
.DD 
	DescricaoDD $
}EE 
)EE 
;EE 
}FF 	
publicHH 
voidHH 
RemoveHH 
(HH 
shortHH  
idHH! #
)HH# $
{II 	

ConnectionJJ 
.JJ 
ExecuteJJ 
(JJ 
$strKK (
,KK( )
commandTypeLL 
:LL 
CommandTypeLL (
.LL( )
StoredProcedureLL) 8
,LL8 9
paramMM 
:MM 
newMM 
{NN 
IdOO 
=OO 
idOO 
}PP 
)QQ 
;QQ 
}RR 	
publicTT 
voidTT 
RemoveTT 
(TT 
GuidTT 
codigoTT  &
)TT& '
{UU 	

ConnectionVV 
.VV 
ExecuteVV 
(VV 
$strWW (
,WW( )
commandTypeXX 
:XX 
CommandTypeXX (
.XX( )
StoredProcedureXX) 8
,XX8 9
paramYY 
:YY 
newYY 
{ZZ 
Codigo[[ 
=[[ 
codigo[[ #
}\\ 
)]] 
;]] 
}^^ 	
public`` 
void`` 
Update`` 
(`` 
	Categoria`` $
entity``% +
)``+ ,
{aa 	

Connectionbb 
.bb 
Executebb 
(bb 
$strcc (
,cc( )
commandTypedd 
:dd 
CommandTypedd (
.dd( )
StoredProceduredd) 8
,dd8 9
paramee 
:ee 
newee 
{ff 
entitygg 
.gg 
Idgg 
,gg 
entityhh 
.hh 
Titulohh !
,hh! "
entityii 
.ii 
	Descricaoii $
,ii$ %
entityjj 
.jj 
Codigojj !
,jj! "
entitykk 
.kk 
Ativokk  
,kk  !
entityll 
.ll 
DataUltimaAlteracaoll .
}mm 
)nn 
;nn 
}oo 	
publicqq 
voidqq 
Removeqq 
(qq 
intqq 
idqq !
)qq! "
{rr 	
throwss 
newss #
NotImplementedExceptionss -
(ss- .
)ss. /
;ss/ 0
}tt 	
publicvv 
	Categoriavv 
FindByIdvv !
(vv! "
intvv" %
idvv& (
)vv( )
{ww 	
throwxx 
newxx #
NotImplementedExceptionxx -
(xx- .
)xx. /
;xx/ 0
}yy 	
}zz 
}{{ úY
RC:\Projetos\Receitas\src\DevWebReceitas.Infra.Data\Repository\ReceitaRepository.cs
	namespace 	
DevWebReceitas
 
. 
Infra 
. 
Data #
.# $

Repository$ .
{ 
public 

class 
ReceitaRepository "
:# $
RepositoryBase% 3
,3 4
IReceitaRepository5 G
{ 
public 
ReceitaRepository  
(  !
IConfiguration! /
configuration0 =
)= >
:? @
baseA E
(E F
configurationF S
)S T
{ 	
} 	
public 
void 
Create 
( 
Receita "
entity# )
)) *
{ 	

Connection 
. 
Execute 
( 
$str &
,& '
commandType 
: 
CommandType (
.( )
StoredProcedure) 8
,8 9
param 
: 
new 
{ 
entity 
. 
Codigo !
,! "
entity 
. 
Titulo !
,! "
entity 
. 
	Descricao $
,$ %
entity 
. 
ModoPreparo &
,& '
entity 
. 
CaminhoImagem (
,( )
entity 
. 
NomeArquivo &
,& '
entity   
.   
Ingredientes   '
,  ' (
CategoriaId!! 
=!!  !
entity!!" (
.!!( )
	Categoria!!) 2
.!!2 3
Id!!3 5
,!!5 6
entity"" 
."" 
Ativo""  
,""  !
entity## 
.## 
DataCadastro## '
}$$ 
)%% 
;%% 
}&& 	
public(( 
void(( 
Remove(( 
((( 
int(( 
id(( !
)((! "
{)) 	

Connection** 
.** 
Execute** 
(** 
$str++ &
,++& '
commandType,, 
:,, 
CommandType,, (
.,,( )
StoredProcedure,,) 8
,,,8 9
param-- 
:-- 
new-- 
{.. 
Id// 
=// 
id// 
}00 
)11 
;11 
}22 	
public44 
void44 
Remove44 
(44 
Guid44 
codigo44  &
)44& '
{55 	

Connection66 
.66 
Execute66 
(66 
$str77 ,
,77, -
commandType88 
:88 
CommandType88 (
.88( )
StoredProcedure88) 8
,888 9
param99 
:99 
new99 
{:: 
Codigo;; 
=;; 
codigo;; #
}<< 
)== 
;== 
}>> 	
public@@ 
Receita@@ 
FindById@@ 
(@@  
int@@  #
id@@$ &
)@@& '
{AA 	
varBB 
objBB 
=BB 

ConnectionBB  
.BB  ! 
QuerySingleOrDefaultBB! 5
(BB5 6
$strBB6 M
,BBM N
commandTypeCC 
:CC 
CommandTypeCC $
.CC$ %
StoredProcedureCC% 4
,CC4 5
paramDD 
:DD 
newDD 
{DD 
IdDD 
=DD 
idDD  
}DD! "
)DD" #
;DD# $
ifFF 
(FF 
objFF 
==FF 
nullFF 
)FF 
throwGG 
newGG 
ArgumentExceptionGG +
(GG+ ,
$strGG, D
)GGD E
;GGE F
returnII 
	MapFromDBII 
(II 
objII  
)II  !
;II! "
}JJ 	
publicLL 
ReceitaLL 

FindByCodeLL !
(LL! "
GuidLL" &
codigoLL' -
)LL- .
{MM 	
varNN 
objNN 
=NN 

ConnectionNN  
.NN  ! 
QuerySingleOrDefaultNN! 5
(NN5 6
$strNN6 O
,NNO P
commandTypeOO 
:OO 
CommandTypeOO $
.OO$ %
StoredProcedureOO% 4
,OO4 5
paramPP 
:PP 
newPP 
{PP 
CodigoPP 
=PP  !
codigoPP" (
}PP) *
)PP* +
;PP+ ,
ifRR 
(RR 
objRR 
==RR 
nullRR 
)RR 
throwSS 
newSS 
ArgumentExceptionSS +
(SS+ ,
$strSS, D
)SSD E
;SSE F
returnUU 
	MapFromDBUU 
(UU 
objUU  
)UU  !
;UU! "
}VV 	
publicXX 
IEnumerableXX 
<XX 
ReceitaXX "
>XX" #
ListXX$ (
(XX( )
ReceitaFilterXX) 6
filterXX7 =
)XX= >
{YY 	
varZZ 
resultZZ 
=ZZ 

ConnectionZZ #
.ZZ# $
QueryZZ$ )
(ZZ) *
$str[[ &
,[[& '
commandType\\ 
:\\ 
CommandType\\ #
.\\# $
StoredProcedure\\$ 3
,\\3 4
param]] 
:]] 
new]] 
{]] 
filter]] 
.]] 
Titulo]] %
,]]% &
filter^^ 
.^^ 
	Descricao^^ (
,^^( )
filter__ 
.__ 
Ingredientes__ +
,__+ ,
filter`` 
.`` 
ModoPreparo`` *
,``* +
filteraa 
.aa 
TituloCategoriaaa .
}bb 
)bb 
;bb 
returncc 
	MapFromDBcc 
(cc 
resultcc #
)cc# $
;cc$ %
}dd 	
publicff 
voidff 
Updateff 
(ff 
Receitaff "
entityff# )
)ff) *
{gg 	

Connectionhh 
.hh 
Executehh 
(hh 
$strii &
,ii& '
commandTypejj 
:jj 
CommandTypejj (
.jj( )
StoredProcedurejj) 8
,jj8 9
paramkk 
:kk 
newkk 
{ll 
entitymm 
.mm 
Idmm 
,mm 
entitynn 
.nn 
Codigonn !
,nn! "
entityoo 
.oo 
Titulooo !
,oo! "
entitypp 
.pp 
	Descricaopp $
,pp$ %
entityqq 
.qq 
ModoPreparoqq &
,qq& '
entityrr 
.rr 
NomeArquivorr &
,rr& '
entityss 
.ss 
CaminhoImagemss (
,ss( )
entitytt 
.tt 
Ingredientestt '
,tt' (
CategoriaIduu 
=uu  !
entityuu" (
.uu( )
	Categoriauu) 2
.uu2 3
Iduu3 5
,uu5 6
entityvv 
.vv 
Ativovv  
,vv  !
entityww 
.ww 
DataUltimaAlteracaoww .
}xx 
)yy 
;yy 
}zz 	
public|| 
void|| 
Like|| 
(|| 
int|| 
id|| 
)||  
{}} 	

Connection~~ 
.~~ 
Execute~~ 
(~~ 
$str $
,$ %
commandType
ÄÄ 
:
ÄÄ 
CommandType
ÄÄ (
.
ÄÄ( )
StoredProcedure
ÄÄ) 8
,
ÄÄ8 9
param
ÅÅ 
:
ÅÅ 
new
ÅÅ 
{
ÇÇ 
Id
ÉÉ 
=
ÉÉ 
id
ÉÉ 
}
ÑÑ 
)
ÖÖ 
;
ÖÖ 
}
ÜÜ 	
public
àà 
void
àà 
Dislike
àà 
(
àà 
int
àà 
id
àà  "
)
àà" #
{
ââ 	

Connection
ää 
.
ää 
Execute
ää 
(
ää 
$str
ãã '
,
ãã' (
commandType
åå 
:
åå 
CommandType
åå (
.
åå( )
StoredProcedure
åå) 8
,
åå8 9
param
çç 
:
çç 
new
çç 
{
éé 
Id
èè 
=
èè 
id
èè 
}
êê 
)
ëë 
;
ëë 
}
íí 	
public
ïï 
Receita
ïï 
	MapFromDB
ïï  
(
ïï  !
dynamic
ïï! (
obj
ïï) ,
)
ïï, -
{
ññ 	
return
óó 
new
óó 
Receita
óó 
{
òò 
Id
ôô 
=
ôô 
obj
ôô 
.
ôô 
Id
ôô 
,
ôô 
Codigo
öö 
=
öö 
obj
öö 
.
öö 
Codigo
öö #
,
öö# $
Titulo
õõ 
=
õõ 
obj
õõ 
.
õõ 
Titulo
õõ #
,
õõ# $
	Descricao
úú 
=
úú 
obj
úú 
.
úú  
	Descricao
úú  )
,
úú) *
ModoPreparo
ùù 
=
ùù 
obj
ùù !
.
ùù! "
ModoPreparo
ùù" -
,
ùù- .
NomeArquivo
ûû 
=
ûû 
obj
ûû !
.
ûû! "
NomeArquivo
ûû" -
,
ûû- .
CaminhoImagem
üü 
=
üü 
obj
üü  #
.
üü# $
CaminhoImagem
üü$ 1
,
üü1 2
Ingredientes
†† 
=
†† 
obj
†† "
.
††" #
Ingredientes
††# /
,
††/ 0
Likes
°° 
=
°° 
obj
°° 
.
°° 
Likes
°° !
,
°°! "
DisLikes
¢¢ 
=
¢¢ 
obj
¢¢ 
.
¢¢ 
DisLikes
¢¢ '
,
¢¢' (
	Categoria
££ 
=
££ 
new
££ 
	Categoria
££  )
{
££* +
Id
§§ 
=
§§ 
obj
§§ 
.
§§ 
CategoriaId
§§ (
,
§§( )
Codigo
•• 
=
•• 
obj
••  
.
••  !
CategoriaCodigo
••! 0
,
••0 1
Titulo
¶¶ 
=
¶¶ 
obj
¶¶  
.
¶¶  !
CategoriaTitulo
¶¶! 0
}
¶¶1 2
,
¶¶2 3
Ativo
ßß 
=
ßß 
obj
ßß 
.
ßß 
Ativo
ßß !
,
ßß! "
DataCadastro
®® 
=
®® 
obj
®® "
.
®®" #
DataCadastro
®®# /
,
®®/ 0
}
©© 
;
©© 
}
™™ 	
public
¨¨ 
IEnumerable
¨¨ 
<
¨¨ 
Receita
¨¨ "
>
¨¨" #
	MapFromDB
¨¨$ -
(
¨¨- .
IEnumerable
¨¨. 9
<
¨¨9 :
dynamic
¨¨: A
>
¨¨A B
obj
¨¨C F
)
¨¨F G
{
≠≠ 	
return
ÆÆ 
obj
ÆÆ 
.
ÆÆ 
Select
ÆÆ 
(
ÆÆ 
x
ÆÆ 
=>
ÆÆ  "
(
ÆÆ# $
Receita
ÆÆ$ +
)
ÆÆ+ ,
	MapFromDB
ÆÆ, 5
(
ÆÆ5 6
x
ÆÆ6 7
)
ÆÆ7 8
)
ÆÆ8 9
;
ÆÆ9 :
}
ØØ 	
}
±± 
}≤≤ Ô
OC:\Projetos\Receitas\src\DevWebReceitas.Infra.Data\Repository\RepositoryBase.cs
	namespace 	
DevWebReceitas
 
. 
Infra 
. 
Data #
.# $

Repository$ .
{ 
public 

abstract 
class 
RepositoryBase (
{		 
internal

 
const

 
string

  
CONNECTIONSTRING_KEY

 2
=

3 4
$str

5 H
;

H I
internal 
IDbConnection 

Connection )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
	protected 
RepositoryBase  
(  !
IConfiguration! /
configuration0 =
)= >
{ 	
var 
connectionString  
=! "
configuration# 0
.0 1
GetConnectionString1 D
(D E 
CONNECTIONSTRING_KEYE Y
)Y Z
;Z [
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
connectionString* :
): ;
); <
throw 
new !
ArgumentNullException /
(/ 0
connectionString0 @
,@ A
$strB _
)_ `
;` a

Connection 
= 
new 
SqlConnection *
(* +
connectionString+ ;
); <
;< =
} 	
public 
IDbTransaction 
Transaction )
{* +
get, /
;/ 0
private1 8
set9 <
;< =
}> ?
public 
void 
SetTransaction "
(" #
IDbTransaction# 1
transaction2 =
)= >
{ 	
this 
. 
Transaction 
= 
transaction *
;* +

Connection 
= 
transaction $
.$ %

Connection% /
;/ 0
} 	
internal   
void   
SetConnection   #
(  # $
IDbConnection  $ 1

connection  2 <
)  < =
{!! 	
this"" 
."" 

Connection"" 
="" 

connection"" (
;""( )
Transaction## 
=## 
null## 
;## 
}$$ 	
}%% 
}&& 