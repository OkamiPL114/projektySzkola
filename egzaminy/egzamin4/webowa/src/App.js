import './App.css';
import React, {useState} from "react";
import NewPost from './components/NewPost';
import Posts from './components/Posts';

function App() {
	const [isNewPostVisible, setIsNewPostVisible] = useState(false);
	const [posts, setPosts] = useState([]);

	function showNewPost(event){
		event.preventDefault();
		setIsNewPostVisible(!isNewPostVisible);
	}
	function addNewPost(newPost){
		setPosts(prevPosts => [...prevPosts, newPost]);
		console.log(posts);
	}
	return (
		<>
			<div className='baner'>
				<div className='banerTitle'>Blog</div>
				<div>
					<form onSubmit={showNewPost}>
						<button type='submit' className='banerButton'>Nowy post</button>
					</form>
				</div>
			</div>
			<NewPost isVisible={isNewPostVisible} addNewPost={addNewPost}/>
			<Posts posts={posts}/>
		</>
	);
}

export default App;
