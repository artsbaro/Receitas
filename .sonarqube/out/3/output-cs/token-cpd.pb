�
\C:\Projetos\Receitas\src\DevWebReceitas.Application\Attributes\AllowedExtensionsAttribute.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %

Attributes% /
{ 
public		 

class		 &
AllowedExtensionsAttribute		 +
:		, -
ValidationAttribute		. A
{

 
private 
readonly 
string 
[  
]  !
_Extensions" -
;- .
public &
AllowedExtensionsAttribute )
() *
string* 0
[0 1
]1 2

Extensions3 =
)= >
{
_Extensions 
= 

Extensions $
;$ %
} 	
	protected 
override 
ValidationResult +
IsValid, 3
(3 4
object 
value 
, 
ValidationContext '
validationContext( 9
)9 :
{ 	
var 
file 
= 
value 
as 
	IFormFile  )
;) *
var 
	extension 
= 
Path  
.  !
GetExtension! -
(- .
file. 2
.2 3
FileName3 ;
); <
;< =
if 
( 
! 
_Extensions 
. 
Contains %
(% &
	extension& /
./ 0
ToLower0 7
(7 8
)8 9
)9 :
): ;
return 
new 
ValidationResult +
(+ ,
GetErrorMessage, ;
(; <
)< =
)= >
;> ?
return 
ValidationResult #
.# $
Success$ +
;+ ,
} 	
public 
string 
GetErrorMessage %
(% &
)& '
{ 	
return 
$" 
$str 4
"4 5
;5 6
} 	
}   
}!! �
VC:\Projetos\Receitas\src\DevWebReceitas.Application\Attributes\MaxFileSizeAttribute.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %

Attributes% /
{ 
public 

class  
MaxFileSizeAttribute %
:& '
ValidationAttribute( ;
{ 
private		 
readonly		 
int		 
_maxFileSize		 )
;		) *
public

  
MaxFileSizeAttribute

 #
(

# $
int

$ '
maxFileSize

( 3
)

3 4
{ 	
_maxFileSize 
= 
maxFileSize &
;& '
}
	protected 
override 
ValidationResult +
IsValid, 3
(3 4
object 
value 
, 
ValidationContext '
validationContext( 9
)9 :
{ 	
if 
( 
value 
is 
	IFormFile "
file# '
&&( *
file+ /
./ 0
Length0 6
>7 8
_maxFileSize9 E
)E F
{ 
return 
new 
ValidationResult +
(+ ,
GetErrorMessage, ;
(; <
)< =
)= >
;> ?
} 
return 
ValidationResult #
.# $
Success$ +
;+ ,
} 	
public 
string 
GetErrorMessage %
(% &
)& '
{ 	
return 
$" 
$str 0
{0 1
_maxFileSize2 >
}> ?
$str? F
"F G
;G H
} 	
} 
} �
RC:\Projetos\Receitas\src\DevWebReceitas.Application\Dtos\Categoria\CategoriaDto.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Dtos% )
.) *
	Categoria* 3
{ 
public 

class 
CategoriaDto 
{ 
[		 	
Required			 
(		 
ErrorMessage		 
=		  
$str		! 9
)		9 :
]		: ;
public

 
Guid

 
Codigo

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
[ 	
Required	 
( 
ErrorMessage 
=  
$str! 7
)7 8
]8 9
[
	MinLength
(
$num
,
ErrorMessage
=
$str
)
]
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage $
=% &
$str' O
)O P
]P Q
[ 	
DisplayName	 
( 
$str 
) 
] 
public 
string 
Titulo 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
Required	 
( 
ErrorMessage 
=  
$str! 7
)7 8
]8 9
[ 	
	MinLength	 
( 
$num 
, 
ErrorMessage "
=# $
$str% J
)J K
]K L
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage $
=% &
$str' O
)O P
]P Q
[ 	
DisplayName	 
( 
$str  
)  !
]! "
public 
string 
	Descricao 
{  !
get" %
;% &
set' *
;* +
}, -
} 
} �
XC:\Projetos\Receitas\src\DevWebReceitas.Application\Dtos\Categoria\CategoriaInsertDto.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Dtos% )
.) *
	Categoria* 3
{ 
public 

class 
CategoriaInsertDto #
{ 
[ 	
Required	 
( 
ErrorMessage 
=  
$str! 7
)7 8
]8 9
[ 	
	MinLength	 
( 
$num 
, 
ErrorMessage "
=# $
$str% J
)J K
]K L
[		 	
	MaxLength			 
(		 
$num		 
,		 
ErrorMessage		 $
=		% &
$str		' O
)		O P
]		P Q
public

 
string

 
Titulo

 
{

 
get

 "
;

" #
set

$ '
;

' (
}

) *
[ 	
Required	 
( 
ErrorMessage 
=  
$str! 7
)7 8
]8 9
[
	MinLength
(
$num
,
ErrorMessage
=
$str
)
]
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage $
=% &
$str' O
)O P
]P Q
public 
string 
	Descricao 
{  !
get" %
;% &
set' *
;* +
}, -
} 
} �
NC:\Projetos\Receitas\src\DevWebReceitas.Application\Dtos\Receita\ReceitaDto.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Dtos% )
.) *
Receita* 1
{ 
public		 

class		 

ReceitaDto		 
{

 
[ 	
Required	 
( 
ErrorMessage 
=  
$str! 9
)9 :
]: ;
public 
Guid 
Codigo 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
( 
ErrorMessage 
=  
$str! <
)< =
]= >
public 
CategoriaDto 
	Categoria %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[ 	
Required	 
( 
ErrorMessage 
=  
$str! 9
)9 :
]: ;
[ 	
	MinLength	 
( 
$num 
, 
ErrorMessage "
=# $
$str% L
)L M
]M N
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage $
=% &
$str' Q
)Q R
]R S
[ 	
DisplayName	 
( 
$str 
) 
] 
public 
string 
Titulo 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
	MinLength	 
( 
$num 
, 
ErrorMessage "
=# $
$str% O
)O P
]P Q
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage $
=% &
$str' T
)T U
]U V
[ 	
DisplayName	 
( 
$str  
)  !
]! "
public 
string 
	Descricao 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
	MinLength	 
( 
$num 
, 
ErrorMessage "
=# $
$str% U
)U V
]V W
[ 	
DisplayName	 
( 
$str &
)& '
]' (
public 
string 
ModoPreparo !
{" #
get$ '
;' (
set) ,
;, -
}. /
[   	
Required  	 
(   
ErrorMessage   
=    
$str  ! ?
)  ? @
]  @ A
[!! 	
	MinLength!!	 
(!! 
$num!! 
,!! 
ErrorMessage!! "
=!!# $
$str!!% R
)!!R S
]!!S T
["" 	
	MaxLength""	 
("" 
$num"" 
,"" 
ErrorMessage"" %
=""& '
$str""( Y
)""Y Z
]""Z [
[## 	
DisplayName##	 
(## 
$str## #
)### $
]##$ %
public$$ 
string$$ 
Ingredientes$$ "
{$$# $
get$$% (
;$$( )
set$$* -
;$$- .
}$$/ 0
public&& 
	IFormFile&& 
Imagem&& 
{&&  !
get&&" %
;&&% &
set&&' *
;&&* +
}&&, -
public(( 
int(( 
Likes(( 
{(( 
get(( 
;(( 
set((  #
;((# $
}((% &
public** 
int** 
Dislikes** 
{** 
get** !
;**! "
set**# &
;**& '
}**( )
}++ 
},, �
RC:\Projetos\Receitas\src\DevWebReceitas.Application\Dtos\Receita\ReceitaEditDto.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Dtos% )
.) *
Receita* 1
{ 
public 

class 
ReceitaEditDto 
{		 
[

 	
Required

	 
(

 
ErrorMessage

 
=

  
$str

! 9
)

9 :
]

: ;
public 
Guid 
Codigo 
{ 
get  
;  !
set" %
;% &
}' (
[
Required
(
ErrorMessage
=
$str
)
]
public 
Guid 
CodigoCategoria #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
Required	 
( 
ErrorMessage 
=  
$str! 9
)9 :
]: ;
[ 	
	MinLength	 
( 
$num 
, 
ErrorMessage "
=# $
$str% L
)L M
]M N
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage $
=% &
$str' Q
)Q R
]R S
[ 	
DisplayName	 
( 
$str 
) 
] 
public 
string 
Titulo 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
	MinLength	 
( 
$num 
, 
ErrorMessage "
=# $
$str% O
)O P
]P Q
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage $
=% &
$str' T
)T U
]U V
[ 	
DisplayName	 
( 
$str  
)  !
]! "
public 
string 
	Descricao 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
	MinLength	 
( 
$num 
, 
ErrorMessage "
=# $
$str% U
)U V
]V W
[ 	
DisplayName	 
( 
$str &
)& '
]' (
public 
string 
ModoPreparo !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
Required	 
( 
ErrorMessage 
=  
$str! ?
)? @
]@ A
[   	
	MinLength  	 
(   
$num   
,   
ErrorMessage   "
=  # $
$str  % R
)  R S
]  S T
[!! 	
	MaxLength!!	 
(!! 
$num!! 
,!! 
ErrorMessage!! %
=!!& '
$str!!( Y
)!!Y Z
]!!Z [
["" 	
DisplayName""	 
("" 
$str"" #
)""# $
]""$ %
public## 
string## 
Ingredientes## "
{### $
get##% (
;##( )
set##* -
;##- .
}##/ 0
public%% 
	IFormFile%% 
Imagem%% 
{%%  !
get%%" %
;%%% &
set%%' *
;%%* +
}%%, -
}&& 
}'' �
TC:\Projetos\Receitas\src\DevWebReceitas.Application\Dtos\Receita\ReceitaInsertDto.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Dtos% )
.) *
Receita* 1
{ 
public 

class 
ReceitaInsertDto !
{		 
[

 	
Required

	 
(

 
ErrorMessage

 
=

  
$str

! 9
)

9 :
]

: ;
[ 	
	MinLength	 
( 
$num 
, 
ErrorMessage "
=# $
$str% L
)L M
]M N
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage $
=% &
$str' Q
)Q R
]R S
[
DisplayName
(
$str
)
]
public 
string 
Titulo 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
	MinLength	 
( 
$num 
, 
ErrorMessage "
=# $
$str% O
)O P
]P Q
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage $
=% &
$str' T
)T U
]U V
[ 	
DisplayName	 
( 
$str  
)  !
]! "
public 
string 
	Descricao 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
	MinLength	 
( 
$num 
, 
ErrorMessage "
=# $
$str% U
)U V
]V W
[ 	
DisplayName	 
( 
$str &
)& '
]' (
public 
string 
ModoPreparo !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
Required	 
( 
ErrorMessage 
=  
$str! F
)F G
]G H
public 
Guid 
CodigoCategoria #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
Required	 
( 
ErrorMessage 
=  
$str! ?
)? @
]@ A
[ 	
	MinLength	 
( 
$num 
, 
ErrorMessage "
=# $
$str% R
)R S
]S T
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage %
=& '
$str( Y
)Y Z
]Z [
[ 	
DisplayName	 
( 
$str #
)# $
]$ %
public   
string   
Ingredientes   "
{  # $
get  % (
;  ( )
set  * -
;  - .
}  / 0
public"" 
	IFormFile"" 
Imagem"" 
{""  !
get""" %
;""% &
set""' *
;""* +
}"", -
}## 
}$$ �
JC:\Projetos\Receitas\src\DevWebReceitas.Application\Dtos\Types\TypeBase.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Dtos% )
.) *
Types* /
{ 
public 

class 
TypeBase 
{ 
public 
short 
Id 
{ 
get 
; 
set "
;" #
}$ %
public 
string 
	Descricao 
{  !
get" %
;% &
set' *
;* +
}, -
} 
} �
SC:\Projetos\Receitas\src\DevWebReceitas.Application\Extensions\ReceitaExtensions.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %

Extensions% /
{ 
public 

static 
class 
ReceitaExtensions )
{ 
public 
static 
byte 
[ 
] 
ConvertToBytes +
(+ ,
this, 0
	IFormFile1 :
image; @
)@ A
{		 	
if

 
(

 
image

 
==

 
null

 
)

 
{ 
return 
new 
byte 
[  
]  !
{" #
}$ %
;% &
}
using 
( 
var 
inputStream "
=# $
image% *
.* +
OpenReadStream+ 9
(9 :
): ;
); <
using 
( 
var 
stream 
= 
new  #
MemoryStream$ 0
(0 1
)1 2
)2 3
{ 
inputStream 
. 
CopyTo "
(" #
stream# )
)) *
;* +
return 
stream 
. 
ToArray %
(% &
)& '
;' (
} 
} 	
} 
} �
SC:\Projetos\Receitas\src\DevWebReceitas.Application\Interfaces\ICategoriaService.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %

Interfaces% /
{ 
public 

	interface 
ICategoriaService &
:' (
IServiceBase) 5
<5 6
CategoriaDto6 B
>B C
{		 
Guid

 
Create


(

 
CategoriaInsertDto

 &
dto

' *
)

* +
;

+ ,
void 
Remove
( 
Guid 
codigo 
)  
;  !
IEnumerable 
< 
CategoriaDto  
>  !
List" &
(& '
CategoriaFilter' 6
filter7 =
)= >
;> ?
void
Update
(
CategoriaDto
dto
)
;
} 
} �
QC:\Projetos\Receitas\src\DevWebReceitas.Application\Interfaces\IReceitaService.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %

Interfaces% /
{ 
public 

	interface 
IReceitaService $
:% &
IServiceBase' 3
<3 4

ReceitaDto4 >
>> ?
{		 
Guid

 
Create


(

 
ReceitaInsertDto

 $
dto

% (
)

( )
;

) *
void 
Remove
( 
Guid 
codigo 
)  
;  !
ReceitaEditDto 
FindByCodeEditDto (
(( )
Guid) -
codigo. 4
)4 5
;5 6
IEnumerable
<

ReceitaDto
>
List
(

filter
)
;
void 
Update
( 
ReceitaEditDto "
dto# &
)& '
;' (
void 
Update
( 

ReceitaDto 
dto "
)" #
;# $
byte 
[ 
]
FindImageByCode 
( 
Guid #
codigo$ *
)* +
;+ ,
void 
Like
( 
Guid 
codigo 
) 
; 
void 
Dislike
( 
Guid 
codigo  
)  !
;! "
} 
} �
NC:\Projetos\Receitas\src\DevWebReceitas.Application\Interfaces\IServiceBase.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %

Interfaces% /
{ 
public 

	interface 
IServiceBase !
<! "
out" %
T& '
>' (
{ 
T 	

FindByCode
 
( 
Guid 
codigo  
)  !
;! "
} 
}		 �
TC:\Projetos\Receitas\src\DevWebReceitas.Application\Mappers\Default\TypeConverter.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Mappers% ,
., -
Default- 4
{ 
public 

static 
class 

{ 
public 
static 
T 
	ConvertTo !
<! "
T" #
># $
($ %
object% +
value, 1
)1 2
{ 	
return		 
JsonConvert		 
.		 
DeserializeObject		 0
<		0 1
T		1 2
>		2 3
(		3 4
JsonConvert		4 ?
.		? @
SerializeObject		@ O
(		O P
value		P U
)		U V
)		V W
;		W X
}

 	
} 
} �
FC:\Projetos\Receitas\src\DevWebReceitas.Application\Mappers\IMapper.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Mappers% ,
{ 
public 

	interface 
IMapper 
< 
MapFrom $
,$ %
MapTo& +
>+ ,
{ 
MapTo 
Map 
( 
MapFrom 
source  
)  !
;! "
IEnumerable		 
<		 
MapTo		 
>		 
Map		 
(		 
IEnumerable		 *
<		* +
MapFrom		+ 2
>		2 3
source		4 :
)		: ;
;		; <
}

 
} �
YC:\Projetos\Receitas\src\DevWebReceitas.Application\Mappers\Receitas\IReceitaDtoMapper.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Mappers% ,
., -
Receitas- 5
{ 
public 

	interface 
IReceitaDtoMapper &
:' (
IMapper) 0
<0 1
Receita1 8
,8 9

ReceitaDto: D
>D E
{ 
} 
}		 �
^C:\Projetos\Receitas\src\DevWebReceitas.Application\Mappers\Receitas\IReceitaEditDtoMapper .cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Mappers% ,
., -
Receitas- 5
{ 
public 

	interface !
IReceitaEditDtoMapper *
:+ ,
IMapper- 4
<4 5
Receita5 <
,< =
ReceitaEditDto> L
>L M
{ 
} 
}		 �
VC:\Projetos\Receitas\src\DevWebReceitas.Application\Mappers\Receitas\IReceitaMapper.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Mappers% ,
., -
Receitas- 5
{ 
public 

	interface 
IReceitaMapper #
:$ %
IMapper& -
<- .
ReceitaInsertDto. >
,> ?
Receita@ G
>G H
{ 
} 
}		 �	
XC:\Projetos\Receitas\src\DevWebReceitas.Application\Mappers\Receitas\ReceitaDtoMapper.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Mappers% ,
., -
Receitas- 5
{ 
public		 

class		 
ReceitaDtoMapper		 !
:		" #
IReceitaDtoMapper		$ 5
{

 
public 

ReceitaDto 
Map 
( 
Receita %
source& ,
), -
{ 	
return

.
	ConvertTo
<

ReceitaDto
>
(
source
)
;
} 	
public 
IEnumerable 
< 

ReceitaDto %
>% &
Map' *
(* +
IEnumerable+ 6
<6 7
Receita7 >
>> ?
source@ F
)F G
{ 	
return 
source 
. 
Select  
(  !
x! "
=># %
Map& )
() *
x* +
)+ ,
), -
;- .
} 	
} 
} �
\C:\Projetos\Receitas\src\DevWebReceitas.Application\Mappers\Receitas\ReceitaEditDtoMapper.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Mappers% ,
., -
Receitas- 5
{ 
public		 

class		  
ReceitaEditDtoMapper		 %
:		& '!
IReceitaEditDtoMapper		( =
{

 
public 
ReceitaEditDto 
Map !
(! "
Receita" )
source* 0
)0 1
{ 	
var
dto
=

.
	ConvertTo
<
ReceitaEditDto
>
(
source
)
;
dto 
. 
CodigoCategoria 
=  !
source" (
.( )
	Categoria) 2
.2 3
Codigo3 9
;9 :
return 
dto 
; 
} 	
public 
IEnumerable 
< 
ReceitaEditDto )
>) *
Map+ .
(. /
IEnumerable/ :
<: ;
Receita; B
>B C
sourceD J
)J K
{ 	
return 
source 
. 
Select  
(  !
x! "
=># %
Map& )
() *
x* +
)+ ,
), -
;- .
} 	
} 
} �
UC:\Projetos\Receitas\src\DevWebReceitas.Application\Mappers\Receitas\ReceitaMapper.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Mappers% ,
., -
Receitas- 5
{ 
public		 

class		 

:		  
IReceitaMapper		! /
{

 
public 
Receita 
Map 
( 
ReceitaInsertDto +
source, 2
)2 3
{ 	
return
new
Receita
{ 
Titulo 
= 
source 
.  
Titulo  &
,& '
	Descricao 
= 
source "
." #
	Descricao# ,
,, -
ModoPreparo 
= 
source $
.$ %
ModoPreparo% 0
,0 1
Codigo 
= 
Guid 
. 
NewGuid %
(% &
)& '
,' (
Ingredientes 
= 
source %
.% &
Ingredientes& 2
,2 3
	Categoria 
= 
new 
	Categoria  )
{* +
Codigo, 2
=3 4
source5 ;
.; <
CodigoCategoria< K
}L M
} 
;
} 	
public 
IEnumerable 
< 
Receita "
>" #
Map$ '
(' (
IEnumerable( 3
<3 4
ReceitaInsertDto4 D
>D E
sourceF L
)L M
{ 	
return 
source 
. 
Select  
(  !
x! "
=># %
Map& )
() *
x* +
)+ ,
), -
;- .
} 	
} 
} �
PC:\Projetos\Receitas\src\DevWebReceitas.Application\Services\CategoriaService.cs
	namespace

 	
DevWebReceitas


 
.

 
Application

 $
.

$ %
Services

% -
{ 
public 

class 
CategoriaService !
:" #
ICategoriaService$ 5
{
private 
readonly #
ICategoriaDomainService 0
_service1 9
;9 :
public 
CategoriaService 
(  #
ICategoriaDomainService  7
service8 ?
)? @
{ 	
_service 
= 
service 
; 
} 	
public 
Guid 
Create 
( 
CategoriaInsertDto -
dto. 1
)1 2
{ 	
var 
objPersistencia 
=  !

./ 0
	ConvertTo0 9
<9 :
	Categoria: C
>C D
(D E
dtoE H
)H I
;I J
objPersistencia 
. 
Codigo "
=# $
Guid% )
.) *
NewGuid* 1
(1 2
)2 3
;3 4
_service 
. 
Create 
( 
objPersistencia +
)+ ,
;, -
return 
objPersistencia "
." #
Codigo# )
;) *
} 	
public 
IEnumerable 
< 
CategoriaDto '
>' (
List) -
(- .
CategoriaFilter. =
filter> D
)D E
{ 	
var 
list 
= 
_service 
.  
List  $
($ %
filter% +
)+ ,
;, -
return   

.    !
	ConvertTo  ! *
<  * +
IEnumerable  + 6
<  6 7
CategoriaDto  7 C
>  C D
>  D E
(  E F
list  F J
)  J K
;  K L
}!! 	
public## 
void## 
Remove## 
(## 
Guid## 
codigo##  &
)##& '
{$$ 	
_service%% 
.%% 
Remove%% 
(%% 
codigo%% "
)%%" #
;%%# $
}&& 	
public(( 
CategoriaDto(( 

FindByCode(( &
(((& '
Guid((' +
codigo((, 2
)((2 3
{)) 	
var** 
	Categoria** 
=** 
_service** $
.**$ %

FindByCode**% /
(**/ 0
codigo**0 6
)**6 7
.**7 8
Result**8 >
;**> ?
return++ 

.++  !
	ConvertTo++! *
<++* +
CategoriaDto+++ 7
>++7 8
(++8 9
	Categoria++9 B
)++B C
;++C D
},, 	
public.. 
void.. 
Update.. 
(.. 
CategoriaDto.. '
dto..( +
)..+ ,
{// 	
_service00 
.00 
Update00 
(00 

.00) *
	ConvertTo00* 3
<003 4
	Categoria004 =
>00= >
(00> ?
dto00? B
)00B C
)00C D
;00D E
}11 	
}22 
}33 �E
NC:\Projetos\Receitas\src\DevWebReceitas.Application\Services\ReceitaService.cs
	namespace 	
DevWebReceitas
 
. 
Application $
.$ %
Services% -
{ 
public

class
ReceitaService
:
IReceitaService
{ 
private 
readonly !
IReceitaDomainService .
_service/ 7
;7 8
private 
readonly 
IReceitaDtoMapper *
_receitaDtoMapper+ <
;< =
private 
readonly !
IReceitaEditDtoMapper .!
_receitaEditDtoMapper/ D
;D E
public 
ReceitaService 
( !
IReceitaDomainService 3
service4 ;
,; <
IReceitaDtoMapper  1
receitaDtoMapper2 B
,B C!
IReceitaEditDtoMapper  5 
receitaEditDtoMapper6 J
)J K
{ 	
_service 
= 
service 
; 
_receitaDtoMapper 
= 
receitaDtoMapper  0
;0 1!
_receitaEditDtoMapper !
=" # 
receitaEditDtoMapper$ 8
;8 9
} 	
public 
Guid 
Create 
( 
ReceitaInsertDto +
dto, /
)/ 0
{ 	
var 
codigo 
= 
Guid 
. 
NewGuid %
(% &
)& '
;' (
var   
objPersistencia   
=    !
new  " %
Receita  & -
{!! 
Codigo"" 
="" 
codigo"" 
,""  
Titulo## 
=## 
dto## 
.## 
Titulo## #
,### $
	Descricao$$ 
=$$ 
dto$$ 
.$$  
	Descricao$$  )
,$$) *
ModoPreparo%% 
=%% 
dto%% !
.%%! "
ModoPreparo%%" -
,%%- .
Ingredientes&& 
=&& 
dto&& "
.&&" #
Ingredientes&&# /
,&&/ 0
Imagem'' 
='' 
dto'' 
.'' 
Imagem'' #
?''# $
.''$ %
ConvertToBytes''% 3
(''3 4
)''4 5
,''5 6
NomeArquivo(( 
=(( 
dto(( !
.((! "
Imagem((" (
?((( )
.(() *
FileName((* 2
,((2 3
	Categoria)) 
=)) 
new)) 
	Categoria))  )
{))* +
Codigo)), 2
=))3 4
dto))5 8
.))8 9
CodigoCategoria))9 H
}))I J
}** 
;**
_service,, 
.,, 
Create,, 
(,, 
objPersistencia,, +
),,+ ,
;,,, -
return-- 
objPersistencia-- "
.--" #
Codigo--# )
;--) *
}.. 	
public00 
IEnumerable00 
<00 

ReceitaDto00 %
>00% &
List00' +
(00+ ,

filter00: @
)00@ A
{11 	
var22 
list22 
=22 
_service22 
.22  
List22  $
(22$ %
filter22% +
)22+ ,
;22, -
return33 
_receitaDtoMapper33 $
.33$ %
Map33% (
(33( )
list33) -
)33- .
;33. /
}44 	
public66 
void66 
Remove66 
(66 
Guid66 
codigo66  &
)66& '
{77 	
_service88 
.88 
Remove88 
(88 
codigo88 "
)88" #
;88# $
}99 	
public;; 

ReceitaDto;; 

FindByCode;; $
(;;$ %
Guid;;% )
codigo;;* 0
);;0 1
{<< 	
var== 
receita== 
=== 
_service== "
.==" #

FindByCode==# -
(==- .
codigo==. 4
)==4 5
;==5 6
return>> 
_receitaDtoMapper>> $
.>>$ %
Map>>% (
(>>( )
receita>>) 0
)>>0 1
;>>1 2
}?? 	
public@@ 
ReceitaEditDto@@ 
FindByCodeEditDto@@ /
(@@/ 0
Guid@@0 4
codigo@@5 ;
)@@; <
{AA 	
varBB 
receitaBB 
=BB 
_serviceBB "
.BB" #

FindByCodeBB# -
(BB- .
codigoBB. 4
)BB4 5
;BB5 6
returnCC !
_receitaEditDtoMapperCC (
.CC( )
MapCC) ,
(CC, -
receitaCC- 4
)CC4 5
;CC5 6
}DD 	
publicFF 
byteFF 
[FF 
]FF 
FindImageByCodeFF %
(FF% &
GuidFF& *
codigoFF+ 1
)FF1 2
{GG 	
returnHH 
_serviceHH 
.HH 
FindImageByCodeHH +
(HH+ ,
codigoHH, 2
)HH2 3
;HH3 4
}II 	
publicKK 
voidKK 
UpdateKK 
(KK 
ReceitaEditDtoKK )
dtoKK* -
)KK- .
{LL 	
varMM 
entityMM 
=MM 
newMM 
ReceitaMM $
{NN 
CodigoOO 
=OO 
dtoOO 
.OO 
CodigoOO #
,OO# $
TituloPP 
=PP 
dtoPP 
.PP 
TituloPP #
,PP# $
	DescricaoQQ 
=QQ 
dtoQQ 
.QQ  
	DescricaoQQ  )
,QQ) *
ModoPreparoRR 
=RR 
dtoRR !
.RR! "
ModoPreparoRR" -
,RR- .
IngredientesSS 
=SS 
dtoSS "
.SS" #
IngredientesSS# /
,SS/ 0
ImagemTT 
=TT 
dtoTT 
.TT 
ImagemTT #
?TT# $
.TT$ %
ConvertToBytesTT% 3
(TT3 4
)TT4 5
,TT5 6
NomeArquivoUU 
=UU 
dtoUU !
.UU! "
ImagemUU" (
?UU( )
.UU) *
FileNameUU* 2
,UU2 3
	CategoriaVV 
=VV 
newVV 
	CategoriaVV  )
{VV* +
CodigoVV, 2
=VV3 4
dtoVV5 8
.VV8 9
CodigoCategoriaVV9 H
}VVI J
}WW 
;WW
_serviceYY 
.YY 
UpdateYY 
(YY 
entityYY "
)YY" #
;YY# $
}ZZ 	
public[[ 
void[[ 
Update[[ 
([[ 

ReceitaDto[[ %
dto[[& )
)[[) *
{\\ 	
var]] 
entity]] 
=]] 
new]] 
Receita]] $
{^^ 
Codigo__ 
=__ 
dto__ 
.__ 
Codigo__ #
,__# $
Titulo`` 
=`` 
dto`` 
.`` 
Titulo`` #
,``# $
	Descricaoaa 
=aa 
dtoaa 
.aa  
	Descricaoaa  )
,aa) *
ModoPreparobb 
=bb 
dtobb !
.bb! "
ModoPreparobb" -
,bb- .
Ingredientescc 
=cc 
dtocc "
.cc" #
Ingredientescc# /
,cc/ 0
Imagemdd 
=dd 
dtodd 
.dd 
Imagemdd #
?dd# $
.dd$ %
ConvertToBytesdd% 3
(dd3 4
)dd4 5
,dd5 6
NomeArquivoee 
=ee 
dtoee !
.ee! "
Imagemee" (
?ee( )
.ee) *
FileNameee* 2
,ee2 3
	Categoriaff 
=ff 
newff 
	Categoriaff  )
{ff* +
Codigoff, 2
=ff3 4
dtoff5 8
.ff8 9
	Categoriaff9 B
.ffB C
CodigoffC I
}ffJ K
}gg 
;gg
_serviceii 
.ii 
Updateii 
(ii 
entityii "
)ii" #
;ii# $
}jj 	
publicmm 
voidmm 
Likemm 
(mm 
Guidmm 
codigomm $
)mm$ %
{nn 	
_serviceoo 
.oo 
Likeoo 
(oo 
codigooo  
)oo  !
;oo! "
}pp 	
publicrr 
voidrr 
Dislikerr 
(rr 
Guidrr  
codigorr! '
)rr' (
{ss 	
_servicett 
.tt 
Dislikett 
(tt 
codigott #
)tt# $
;tt$ %
}uu 	
}vv 
}ww 