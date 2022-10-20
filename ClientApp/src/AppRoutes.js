import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { AddBook } from "./components/AddBook";
import { Home } from "./components/Home";
import { Excerpt } from "./components/Excerpt"

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/addBook',
    element: <AddBook />
  },
  {
    path: '/excerpts',
    element: <Excerpt />
  }
];

export default AppRoutes;
