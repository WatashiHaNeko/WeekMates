## WeekMates

### For development

1. **Add localhost subdomain mapping**

Add localhost subdomain mapping on `/etc/hosts` as below.
Nginx reverse proxy checks subdomains to provide suitable service.

``` text
# /etc/hosts
127.0.0.1	*.localhost
```

2. **Start containers**

``` bash
$ docker-compose up -d
```

3. **Access API Server**

http://api-server.localhost:8080

4. **Access Swagger Editor**

http://swagger-editor.localhost:8080

**Swagger Editor**

> Swagger Editor is one of the most powerful design tools for developers to define APIs using OAS 2.0 & OAS 3.0.
>
> https://swagger.io/tools/swagger-editor/

**OpenAPI Specification (OAS)**

> The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection.
>
> http://spec.openapis.org/oas/v3.0.3
