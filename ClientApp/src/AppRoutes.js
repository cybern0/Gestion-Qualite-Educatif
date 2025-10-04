import { REM } from "./components/REM";
import { RES } from "./components/RES";
import { MultiGrade } from "./components/MultiGrade";
import { Manuel } from "./components/Manuel";
import { Places } from "./components/Places";
import { NewFPE } from "./components/NewFPE";
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
    path: '/new-fpe',
    element: <NewFPE />
  }
];

export default AppRoutes;
