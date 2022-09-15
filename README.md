# Neto Core example
* Net core api with EF
* API to management movies of cinemas, include CRUD features and CustomIdentityUser validation (from UsuariosApi)   

### To `FilmesAPI` project only:

###### Libraries
* AutoMapper.Extensions.Microsoft.DependencyInjection" Version="8.1.1"
* FluentResults" Version="2.5.0"
* Microsoft.AspNetCore.Mvc.Formatters.Json" Version="2.2.0"
* Microsoft.AspNetCore.Mvc.NewtonsoftJson" Version="5.0.7"
* Microsoft.EntityFrameworkCore" Version="5.0.5"
* Microsoft.EntityFrameworkCore.Proxies" Version="5.0.5"
* Microsoft.EntityFrameworkCore.Tools" Version="5.0.5">  
* MySql.EntityFrameworkCore" Version="5.0.3"
* Newtonsoft.Json" Version="13.0.1"
* Swashbuckle.AspNetCore" Version="5.6.3"

###### To run application use:
* MySql > create database cinemaDb
* Postman 

###### If EF migrations don't exist, create:
```
add-migration "Criando FilmesApi"
```

###### Set migration on database
```
update-database
```


### To `UsuarioAPI` project only:
* AutoMapper.Extensions.Microsoft.DependencyInjection Version="8.1.1"
* Microsoft.AspNetCore.Identity.EntityFrameworkCore Version="5.0.5"
* Microsoft.IdentityModel.Tokens Version="6.12.0"
* Swashbuckle.AspNetCore Version="5.6.3"
* Microsoft.AspNetCore.Identity Version="2.2.0"
* Microsoft.Extensions.Identity.Stores Version="5.0.5"
* MySql.EntityFrameworkCore Version="5.0.3"
* Microsoft.EntityFrameworkCore.Tools Version="5.0.5"
* FluentResults Version="3.12.0"
* MailKit, MimeKit Version="2.14.0"	
* Microsoft.AspNetCore.Authentication.JwtBearer Version="5.0.11" />
* Microsoft.AspNetCore.Authorization Version="5.0.11" />

Documentation Authentication - Identy configs
https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity-configuration?view=aspnetcore-5.0

###### To run application use:
* MySql > create database usuariodb
* Postman 

######  If EF migrations don't exist, create:
```
add-migration "Criando UsuarioApi"
```

######  Set migration on database
```
update-database
```

######  Setup User Secrets
```
dotnet user-secrets init
dotnet user-secrets set "EmailSettings:From" "maildevtoolstest@gmail.com"
dotnet user-secrets set "EmailSettings:SmtpServer" "smtp.gmail.com"
dotnet user-secrets set "EmailSettings:Port" "465"
dotnet user-secrets set "EmailSettings:Password" "ojvpfnmerpwazeuv"
dotnet user-secrets list


dotnet user-secrets set "admininfo:password" "abc123!"
```