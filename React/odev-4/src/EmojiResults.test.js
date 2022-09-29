import React from "react";
import ReactDOM from "react-dom";
import EmojiResults from "./EmojiResultRow.js";

it("renders without crashing", () => {
  const div = document.createElement("div");
  ReactDOM.render(<EmojiResults />, div);
});

