#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]

namespace MyApp.DataModel
{
	
	
	/// <summary>
	/// Represents a source of entities bound to a Dataverse service. It tracks and manages changes made to the retrieved entities.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.11")]
	public partial class MyOrgContext : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
	{
		
		/// <summary>
		/// Constructor.
		/// </summary>
		public MyOrgContext(Microsoft.Xrm.Sdk.IOrganizationService service) : 
				base(service)
		{
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="MyApp.DataModel.Account"/> entities.
		/// </summary>
		public System.Linq.IQueryable<MyApp.DataModel.Account> AccountSet
		{
			get
			{
				return this.CreateQuery<MyApp.DataModel.Account>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="MyApp.DataModel.ActivityParty"/> entities.
		/// </summary>
		public System.Linq.IQueryable<MyApp.DataModel.ActivityParty> ActivityPartySet
		{
			get
			{
				return this.CreateQuery<MyApp.DataModel.ActivityParty>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="MyApp.DataModel.BusinessUnit"/> entities.
		/// </summary>
		public System.Linq.IQueryable<MyApp.DataModel.BusinessUnit> BusinessUnitSet
		{
			get
			{
				return this.CreateQuery<MyApp.DataModel.BusinessUnit>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="MyApp.DataModel.Contact"/> entities.
		/// </summary>
		public System.Linq.IQueryable<MyApp.DataModel.Contact> ContactSet
		{
			get
			{
				return this.CreateQuery<MyApp.DataModel.Contact>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="MyApp.DataModel.Letter"/> entities.
		/// </summary>
		public System.Linq.IQueryable<MyApp.DataModel.Letter> LetterSet
		{
			get
			{
				return this.CreateQuery<MyApp.DataModel.Letter>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="MyApp.DataModel.Privilege"/> entities.
		/// </summary>
		public System.Linq.IQueryable<MyApp.DataModel.Privilege> PrivilegeSet
		{
			get
			{
				return this.CreateQuery<MyApp.DataModel.Privilege>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="MyApp.DataModel.Role"/> entities.
		/// </summary>
		public System.Linq.IQueryable<MyApp.DataModel.Role> RoleSet
		{
			get
			{
				return this.CreateQuery<MyApp.DataModel.Role>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="MyApp.DataModel.SystemUser"/> entities.
		/// </summary>
		public System.Linq.IQueryable<MyApp.DataModel.SystemUser> SystemUserSet
		{
			get
			{
				return this.CreateQuery<MyApp.DataModel.SystemUser>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="MyApp.DataModel.Team"/> entities.
		/// </summary>
		public System.Linq.IQueryable<MyApp.DataModel.Team> TeamSet
		{
			get
			{
				return this.CreateQuery<MyApp.DataModel.Team>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="MyApp.DataModel.UserQueryVisualization"/> entities.
		/// </summary>
		public System.Linq.IQueryable<MyApp.DataModel.UserQueryVisualization> UserQueryVisualizationSet
		{
			get
			{
				return this.CreateQuery<MyApp.DataModel.UserQueryVisualization>();
			}
		}
	}
}
#pragma warning restore CS1591
