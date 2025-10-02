import { REM } from "./components/REM";
import { RES } from "./components/RES";
import { MultiGrade } from "./components/MultiGrade";
import { Manuel } from "./components/Manuel";
import { Places } from "./components/Places";
import { Account } from "./components/Account";
import { Home } from "./components/Home";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/rem',
    element: <REM />
  },
  {
    path: '/res',
    element: <RES />
  },
  {
    path: '/multi-grade',
    element: <MultiGrade />
  },
  {
    path: '/manuel',
    element: <Manuel />
  },
  {
    path: '/places',
    element: <Places />
  },
  {
    path: '/account',
    element: <Account />
  }
];

export default AppRoutes;
