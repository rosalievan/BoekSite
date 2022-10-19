import { AddBook } from "./components/AddBook";
// import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/addBook',
    element: <AddBook />
  },
];

export default AppRoutes;
