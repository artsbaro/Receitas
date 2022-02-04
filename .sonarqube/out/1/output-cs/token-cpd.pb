�"
QC:\Projetos\Receitas\src\DevWebReceitas.Domain.Services\CategoriaDomainService.cs
	namespace

 	
DevWebReceitas


 
.

 
Domain

 
.

  
Services

  (
{ 
public 

class "
CategoriaDomainService '
:( )#
ICategoriaDomainService* A
{
private 
readonly  
ICategoriaRepository - 
_CategoriaRepository. B
;B C
public "
CategoriaDomainService %
(% & 
ICategoriaRepository& :
CategoriaRepository; N
)N O
{ 	 
_CategoriaRepository  
=! "
CategoriaRepository# 6
;6 7
} 	
public 
void 
Create 
( 
	Categoria $
entity% +
)+ ,
{ 	
using 
( 
var 
trans 
= 
new "
TransactionScope# 3
(3 4
)4 5
)5 6
{ 
_CategoriaRepository $
.$ %
Create% +
(+ ,
entity, 2
)2 3
;3 4
trans 
. 
Complete 
( 
)  
;  !
} 
} 	
public 
async 
Task 
< 
	Categoria #
># $

FindByCode% /
(/ 0
Guid0 4
codigo5 ;
); <
{ 	
return   
await    
_CategoriaRepository   -
.  - .

FindByCode  . 8
(  8 9
codigo  9 ?
)  ? @
;  @ A
}!! 	
public## 
	Categoria## 
FindById## !
(##! "
int##" %
id##& (
)##( )
{$$ 	
return%%  
_CategoriaRepository%% '
.%%' (
FindById%%( 0
(%%0 1
id%%1 3
)%%3 4
;%%4 5
}&& 	
public(( 
IEnumerable(( 
<(( 
	Categoria(( $
>(($ %
List((& *
(((* +
CategoriaFilter((+ :
filter((; A
)((A B
{)) 	
return**  
_CategoriaRepository** '
.**' (
List**( ,
(**, -
filter**- 3
)**3 4
;**4 5
}++ 	
public-- 
void-- 
Remove-- 
(-- 
Guid-- 
codigo--  &
)--& '
{.. 	
using// 
(// 
var// 
trans// 
=// 
new// "
TransactionScope//# 3
(//3 4
)//4 5
)//5 6
{00 
var11 
	categoria11 
=11 

FindByCode11  *
(11* +
codigo11+ 1
)111 2
;112 3 
_CategoriaRepository22 $
.22$ %
Remove22% +
(22+ ,
	categoria22, 5
.225 6
Id226 8
)228 9
;229 :
trans33 
.33 
Complete33 
(33 
)33  
;33  !
}44 
}55 	
public77 
void77 
Update77 
(77 
	Categoria77 $
entity77% +
)77+ ,
{88 	
using99 
(99 
var99 
trans99 
=99 
new99 "
TransactionScope99# 3
(993 4
)994 5
)995 6
{:: 
var;; 
	categoria;; 
=;; 

FindByCode;;  *
(;;* +
entity;;+ 1
.;;1 2
Codigo;;2 8
);;8 9
;;;9 :
entity== 
.== 
Id== 
=== 
(== 
short== "
)==" #
	categoria==# ,
.==, -
Id==- /
;==/ 0
entity>> 
.>> 
DataUltimaAlteracao>> *
=>>+ ,
DateTime>>- 5
.>>5 6
Now>>6 9
;>>9 : 
_CategoriaRepository?? $
.??$ %
Update??% +
(??+ ,
entity??, 2
)??2 3
;??3 4
trans@@ 
.@@ 
Complete@@ 
(@@ 
)@@  
;@@  !
}AA 
}BB 	
}CC 
}DD �	
]C:\Projetos\Receitas\src\DevWebReceitas.Domain.Services\Interfaces\ICategoriaDomainService.cs
	namespace 	
DevWebReceitas
 
. 
Domain 
.  
Services  (
.( )

Interfaces) 3
{ 
public		 

	interface		 #
ICategoriaDomainService		 ,
:		- .
IDomainService		/ =
<		= >
	Categoria		> G
,		G H
Guid		I M
>		M N
{

 
void 
Create
( 
	Categoria 
entity $
)$ %
;% &
void 
Update
( 
	Categoria 
entity $
)$ %
;% &
void
Remove
(
Guid
codigo
)
;
IEnumerable 
< 
	Categoria 
> 
List #
(# $
CategoriaFilter$ 3
filter4 :
): ;
;; <
Task 
< 
	Categoria
> 

FindByCode "
(" #
Guid# '
codigo( .
). /
;/ 0
} 
} �
TC:\Projetos\Receitas\src\DevWebReceitas.Domain.Services\Interfaces\IDomainService.cs
	namespace 	
DevWebReceitas
 
. 
Domain 
.  
Services  (
.( )

Interfaces) 3
{ 
public 

	interface 
IDomainService #
<$ %
T% &
,& '
TCode( -
>- .
{ 
} 
} �
[C:\Projetos\Receitas\src\DevWebReceitas.Domain.Services\Interfaces\IReceitaDomainService.cs
	namespace 	
DevWebReceitas
 
. 
Domain 
.  
Services  (
.( )

Interfaces) 3
{ 
public 

	interface !
IReceitaDomainService *
:+ ,
IDomainService- ;
<; <
Receita< C
,C D
GuidE I
>I J
{		 
void

 
Create


(

 
Receita

 
entity

 "
)

" #
;

# $
void 
Update
( 
Receita 
entity "
)" #
;# $
void 
Remove
( 
Guid 
codigo 
)  
;  !
IEnumerable
<
Receita
>
List
(

filter
)
;
byte 
[ 
]
FindImageByCode 
( 
Guid #
codigo$ *
)* +
;+ ,
void 
Like
( 
Guid 
codigo 
) 
; 
void 
Dislike
( 
Guid 
codigo  
)  !
;! "
Receita 

FindByCode 
( 
Guid 
code  $
)$ %
;% &
} 
} �c
OC:\Projetos\Receitas\src\DevWebReceitas.Domain.Services\ReceitaDomainService.cs
	namespace 	
DevWebReceitas
 
. 
Domain 
.  
Services  (
{ 
public

class
ReceitaDomainService
:
IReceitaDomainService
{ 
private 
readonly 
IReceitaRepository +
_receitaRepository, >
;> ?
private 
readonly  
ICategoriaRepository - 
_categoriaRepository. B
;B C
private 
static 
IHostingEnvironment *
_environment+ 7
;7 8
public  
ReceitaDomainService #
(# $
IReceitaRepository$ 6
receitaRepository7 H
, 
IHostingEnvironment !
environment" -
, 
ICategoriaRepository "
categoriaRepository# 6
)6 7
{ 	
_receitaRepository 
=  
receitaRepository! 2
;2 3
_environment 
= 
environment &
;& ' 
_categoriaRepository  
=! "
categoriaRepository# 6
;6 7
} 	
public 
void 
Create 
( 
Receita "
entity# )
)) *
{ 	
using 
( 
var 
trans 
= 
new "
TransactionScope# 3
(3 4
)4 5
)5 6
{ 
SetCategoriaId   
(   
entity   %
)  % &
;  & '
GravaArquivo!! 
(!! 
entity!! #
)!!# $
;!!$ %
_receitaRepository"" "
.""" #
Create""# )
("") *
entity""* 0
)""0 1
;""1 2
trans## 
.## 
Complete## 
(## 
)##  
;##  !
}$$ 
}%% 	
public'' 
Receita'' 
FindById'' 
(''  
int''  #
id''$ &
)''& '
{(( 	
var)) 
receita)) 
=)) 
_receitaRepository)) ,
.)), -
FindById))- 5
())5 6
id))6 8
)))8 9
;))9 :
return** 
receita** 
;** 
}++ 	
public-- 
Receita-- 

FindByCode-- !
(--! "
Guid--" &
codigo--' -
)--- .
{.. 	
var// 
receita// 
=// 
_receitaRepository// ,
.//, -

FindByCode//- 7
(//7 8
codigo//8 >
)//> ?
;//? @
if00 
(00 
receita00 
==00 
null00 
)00  
throw11 
new11 
ArgumentException11 +
(11+ ,
$str11, D
)11D E
;11E F
return33 
receita33 
;33 
}44 	
public66 
byte66 
[66 
]66 
FindImageByCode66 %
(66% &
Guid66& *
codigo66+ 1
)661 2
{77 	
var88 
receita88 
=88 

FindByCode88 $
(88$ %
codigo88% +
)88+ ,
;88, -
if99 
(99 
receita99 
==99 
null99 
)99  
throw:: 
new:: 
ArgumentException:: +
(::+ ,
$str::, D
)::D E
;::E F
if<< 
(<< 
File<< 
.<< 
Exists<< 
(<< 
receita<< #
.<<# $

)<<1 2
)<<2 3
return== 
File== 
.== 
ReadAllBytes== (
(==( )
receita==) 0
.==0 1

)==> ?
;==? @
throw?? 
new?? 
ArgumentException?? '
(??' (
$str??( @
)??@ A
;??A B
}@@ 	
publicBB 
IEnumerableBB 
<BB 
ReceitaBB "
>BB" #
ListBB$ (
(BB( )

filterBB7 =
)BB= >
{CC 	
returnDD 
_receitaRepositoryDD %
.DD% &
ListDD& *
(DD* +
filterDD+ 1
)DD1 2
;DD2 3
}EE 	
publicGG 
voidGG 
RemoveGG 
(GG 
intGG 
idGG !
)GG! "
{HH 	
_receitaRepositoryII 
.II 
RemoveII %
(II% &
idII& (
)II( )
;II) *
}JJ 	
publicLL 
voidLL 
RemoveLL 
(LL 
GuidLL 
codigoLL  &
)LL& '
{MM 	
varNN 
receitaNN 
=NN 

FindByCodeNN $
(NN$ %
codigoNN% +
)NN+ ,
;NN, -
ifOO 
(OO 
receitaOO 
==OO 
nullOO 
)OO  
throwPP 
newPP 
ArgumentExceptionPP +
(PP+ ,
$strPP, D
)PPD E
;PPE F
ExcluirArquivoRR 
(RR 
receitaRR "
)RR" #
;RR# $
_receitaRepositorySS 
.SS 
RemoveSS %
(SS% &
codigoSS& ,
)SS, -
;SS- .
}TT 	
publicVV 
voidVV 
UpdateVV 
(VV 
ReceitaVV "
entityVV# )
)VV) *
{WW 	
varXX 
receitaXX 
=XX 

FindByCodeXX $
(XX$ %
entityXX% +
.XX+ ,
CodigoXX, 2
)XX2 3
;XX3 4
ifYY 
(YY 
receitaYY 
==YY 
nullYY 
)YY  
throwZZ 
newZZ 
ArgumentExceptionZZ +
(ZZ+ ,
$strZZ, D
)ZZD E
;ZZE F
entity\\ 
.\\ 
Id\\ 
=\\ 
receita\\ 
.\\  
Id\\  "
;\\" #
entity]] 
.]] 
DataUltimaAlteracao]] &
=]]' (
DateTime]]) 1
.]]1 2
Now]]2 5
;]]5 6
entity^^ 
.^^ 

=^^! "
receita^^# *
.^^* +

;^^8 9
using`` 
(`` 
var`` 
trans`` 
=`` 
new`` "
TransactionScope``# 3
(``3 4
)``4 5
)``5 6
{aa 
SetCategoriaIdbb 
(bb 
entitybb %
)bb% &
;bb& '
GravaArquivocc 
(cc 
entitycc #
)cc# $
;cc$ %
_receitaRepositorydd "
.dd" #
Updatedd# )
(dd) *
entitydd* 0
)dd0 1
;dd1 2
transee 
.ee 
Completeee 
(ee 
)ee  
;ee  !
}ff 
}gg 	
privateii 
voidii 
SetCategoriaIdii #
(ii# $
Receitaii$ +
entityii, 2
)ii2 3
{jj 	
varkk 
	categoriakk 
=kk  
_categoriaRepositorykk 0
.kk0 1

FindByCodekk1 ;
(kk; <
entitykk< B
.kkB C
	CategoriakkC L
.kkL M
CodigokkM S
)kkS T
;kkT U
ifll 
(ll 
	categoriall 
==ll 
nullll !
)ll! "
throwmm 
newmm 
ArgumentExceptionmm +
(mm+ ,
$strmm, F
)mmF G
;mmG H
entityoo 
.oo 
	Categoriaoo 
.oo 
Idoo 
=oo  !
(oo" #
shortoo# (
)oo( )
	categoriaoo) 2
.oo2 3
Idoo3 5
;oo5 6
}pp 	
privaterr 
staticrr 
voidrr 
GravaArquivorr (
(rr( )
Receitarr) 0
entityrr1 7
)rr7 8
{ss 	
iftt 
(tt 
entitytt 
.tt 
HasImagett 
)tt  
{uu 
varvv 
pathvv 
=vv 
_environmentvv '
.vv' (
WebRootPathvv( 3
+vv4 5
$strvv6 B
;vvB C
ifxx 
(xx 
!xx 
	Directoryxx 
.xx 
Existsxx %
(xx% &
pathxx& *
)xx* +
)xx+ ,
	Directoryyy 
.yy 
CreateDirectoryyy -
(yy- .
pathyy. 2
)yy2 3
;yy3 4
if{{ 
({{ 
entity{{ 
.{{ 

!={{) +
null{{, 0
){{0 1
ExcluirArquivo|| "
(||" #
entity||# )
)||) *
;||* +
entity~~ 
.~~ 
NomeArquivo~~ "
=~~# $
Guid~~% )
.~~) *
NewGuid~~* 1
(~~1 2
)~~2 3
.~~3 4
ToString~~4 <
(~~< =
)~~= >
+~~? @
new~~A D
FileInfo~~E M
(~~M N
entity~~N T
.~~T U
NomeArquivo~~U `
)~~` a
.~~a b
	Extension~~b k
;~~k l
var
�� 
fullPath
�� 
=
�� 
path
�� #
+
��$ %
entity
��& ,
.
��, -
NomeArquivo
��- 8
;
��8 9
using
�� 
(
�� 
Stream
�� 
file
�� "
=
��# $
File
��% )
.
��) *
	OpenWrite
��* 3
(
��3 4
fullPath
��4 <
)
��< =
)
��= >
{
�� 
file
�� 
.
�� 
Write
�� 
(
�� 
entity
�� %
.
��% &
Imagem
��& ,
,
��, -
$num
��. /
,
��/ 0
entity
��1 7
.
��7 8
Imagem
��8 >
.
��> ?
Length
��? E
)
��E F
;
��F G
file
�� 
.
�� 
Flush
�� 
(
�� 
)
��  
;
��  !
}
�� 
entity
�� 
.
�� 

�� $
=
��% &
fullPath
��' /
;
��/ 0
}
�� 
}
�� 	
private
�� 
static
�� 
void
�� 
ExcluirArquivo
�� *
(
��* +
Receita
��+ 2
entity
��3 9
)
��9 :
{
�� 	
if
�� 
(
�� 
File
�� 
.
�� 
Exists
�� 
(
�� 
entity
�� "
.
��" #

��# 0
)
��0 1
)
��1 2
{
�� 
File
�� 
.
�� 
Delete
�� 
(
�� 
entity
�� "
.
��" #

��# 0
)
��0 1
;
��1 2
}
�� 
}
�� 	
public
�� 
void
�� 
Like
�� 
(
�� 
Guid
�� 
codigo
�� $
)
��$ %
{
�� 	
var
�� 
receita
�� 
=
�� 

FindByCode
�� $
(
��$ %
codigo
��% +
)
��+ ,
;
��, -
if
�� 
(
�� 
receita
�� 
==
�� 
null
�� 
)
��  
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, D
)
��D E
;
��E F 
_receitaRepository
�� 
.
�� 
Like
�� #
(
��# $
receita
��$ +
.
��+ ,
Id
��, .
)
��. /
;
��/ 0
}
�� 	
public
�� 
void
�� 
Dislike
�� 
(
�� 
Guid
��  
codigo
��! '
)
��' (
{
�� 	
var
�� 
receita
�� 
=
�� 

FindByCode
�� $
(
��$ %
codigo
��% +
)
��+ ,
;
��, -
if
�� 
(
�� 
receita
�� 
==
�� 
null
�� 
)
��  
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, D
)
��D E
;
��E F 
_receitaRepository
�� 
.
�� 
Dislike
�� &
(
��& '
receita
��' .
.
��. /
Id
��/ 1
)
��1 2
;
��2 3
}
�� 	
}
�� 
}�� 