    Private Sub MenuItemCallback(ByVal sender As Object, ByVal e As EventArgs)
        Dim pkg As IVsPackage = TryCast(GetService(GetType(Package)), Package)
        pkg.ResetDefaults(CUInt(__VSPKGRESETFLAGS.PKGRF_TOOLBOXITEMS))
    End Sub