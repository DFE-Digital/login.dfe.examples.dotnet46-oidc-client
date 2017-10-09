# login.dfe.examples.dotnet46-oidc-client
Example OIDC client using .NET 4.6

# Running
You will need the following details for the OIDC server:

* URL to OIDC server - It will use well known config to discover login endpoints
* Client Id - This will be provided to you by the OIDC server endpoints

These need adding to Startup.cs

## Using DfE Login locally
For security reasons, DfE Login' OIDC server does not allow either non-secure (Not on https) or localhost connections. You will need to setup your local environment to support this constraint. 

One way to do this would be to use [ngrok](https://ngrok.com/). Download the client for your operating system, then run:

```
ngrok http -host-header=localhost 1885
```

Where 1885 is the port your localmachine is running on. Once started you will be given a http and https url that will forward to your local machine. Use this as your redirect url for OIDC purposes.
