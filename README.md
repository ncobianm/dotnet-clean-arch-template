# dotnet-clean-arch-template

Clean Architecture + DDD template for .NET APIs

## Uso como plantilla (`dotnet new`)

La plantilla se publica en GitHub Packages como `CleanArch.Template`.

1. Instala la plantilla:

   ```bash
   dotnet new install CleanArch.Template
   ```

2. Crea un proyecto nuevo:

   ```bash
   dotnet new cleanarch -n MiEmpresa.MiProyecto
   ```

   Todas las apariciones de `CleanArch` (proyectos, namespaces, solución y ficheros) se sustituyen por el nombre indicado.

Para actualizar: `dotnet new update`. Para desinstalar: `dotnet new uninstall CleanArch.Template`.

## Estructura de la plantilla

- `.template.config/template.json`: configuración que usa `dotnet new` para detectar la plantilla.
- `build/CleanArch.Template.csproj`: proyecto de empaquetado que genera el `.nupkg` de tipo `Template`.
- `build/version.txt`: versión base (`MAJOR.MINOR`) del paquete.
- `.github/workflows/publish-template.yml`: pipeline de compilación, versionado y publicación.

## Versionado y publicación

El pipeline compila la solución, empaqueta la plantilla, valida que genera un proyecto que compila y lo publica en GitHub Packages:

| Disparador        | Versión generada                      | ¿Se publica? |
|-------------------|---------------------------------------|--------------|
| Tag `vX.Y.Z`      | `X.Y.Z`                               | Sí           |
| Push a `main`     | `<version.txt>.<run_number>`          | Sí           |
| Pull request      | `<version.txt>.<run_number>-ci`       | No           |

Para cambiar la versión mayor/menor edita `build/version.txt`.

### Probar en local

```bash
dotnet pack build/CleanArch.Template.csproj -c Release -o ./artifacts
dotnet new install ./artifacts/CleanArch.Template.1.0.0.nupkg
```
