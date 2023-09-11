# ViewComponents
View components are similar to partial views, but they're much more powerful. View components don't use model binding, they depend on the data passed when calling the view component. This article was written using controllers and views, but view components work with Razor Pages.

A view component:
<ul>
  <li>Renders a chunk rather than a whole response.</li>
  <li>Includes the same separation-of-concerns and testability benefits found between a controller and view.</li>
  <li>Can have parameters and business logic.</li>
  <li>Is typically invoked from a layout page.</li>
</ul>

<strong>View components are intended anywhere reusable rendering logic that's too complex for a partial view, such as:<strong>

<ul>
  <li>Dynamic navigation menus</li>
  <li>Tag cloud, where it queries the database</li>
  <li>Sign in panel</li>
  <li>Shopping cart</li>
  <li>Recently published articles</li>
  <li>Sidebar content on a blog</li>
  <li>A sign in panel that would be rendered on every page and show either the links to sign out or sign in, depending on the sign in state of the user</li>
</ul>

